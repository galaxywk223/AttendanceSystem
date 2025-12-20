using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using AMS.ahutit.Common;
using DAL.ahutit;
using Models.ahutit;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace AMS.ahutit
{
    public class StudentImportResult
    {
        public int Total { get; set; }
        public int Success { get; set; }
        public List<string> Errors { get; } = new List<string>();
    }

    public static class StudentImportService
    {
        public static StudentImportResult ImportStudents(string filePath)
        {
            StudentImportResult result = new StudentImportResult();
            StudentService studentService = new StudentService();
            StudentClassService classService = new StudentClassService();
            List<Class> classList = classService.GetAllClass();
            Dictionary<string, int> classNameMap = classList.ToDictionary(c => c.ClassName, c => c.Id, StringComparer.OrdinalIgnoreCase);

            IWorkbook workbook = CreateWorkbook(filePath);
            ISheet sheet = workbook.GetSheetAt(0);
            if (sheet == null)
            {
                result.Errors.Add("未找到工作表。");
                return result;
            }

            IRow headerRow = sheet.GetRow(0);
            if (headerRow == null)
            {
                result.Errors.Add("未找到表头。");
                return result;
            }

            Dictionary<string, int> headerMap = BuildHeaderMap(headerRow);
            Dictionary<string, string> requiredFields = new Dictionary<string, string>
            {
                { "name", "姓名" },
                { "gender", "性别" },
                { "birthday", "出生日期" },
                { "idno", "身份证号" },
                { "cardno", "考勤卡号" }
            };
            foreach (string field in requiredFields.Keys)
            {
                if (!headerMap.ContainsKey(field))
                {
                    result.Errors.Add($"缺少必填列：{requiredFields[field]}");
                }
            }
            if (!headerMap.ContainsKey("classid") && !headerMap.ContainsKey("classname"))
            {
                result.Errors.Add("缺少班级列：班级ID或班级名称");
            }
            if (result.Errors.Count > 0)
            {
                return result;
            }

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                IRow? row = sheet.GetRow(i);
                if (row == null || IsRowEmpty(row))
                {
                    continue;
                }
                result.Total++;
                try
                {
                    string name = GetCellString(row, headerMap["name"]);
                    string gender = NormalizeGender(GetCellString(row, headerMap["gender"]));
                    DateTime birthday = GetCellDate(row, headerMap["birthday"]);
                    string idNo = GetCellString(row, headerMap["idno"]);
                    string cardNo = GetCellString(row, headerMap["cardno"]);
                    string phone = headerMap.ContainsKey("phone") ? GetCellString(row, headerMap["phone"]) : string.Empty;
                    string address = headerMap.ContainsKey("address") ? GetCellString(row, headerMap["address"]) : string.Empty;
                    string image = headerMap.ContainsKey("image") ? GetCellString(row, headerMap["image"]) : string.Empty;
                    int age = headerMap.ContainsKey("age") ? GetCellInt(row, headerMap["age"]) : CalculateAge(birthday);

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        result.Errors.Add($"第{i + 1}行：姓名为空");
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(gender))
                    {
                        result.Errors.Add($"第{i + 1}行：性别为空或不合法");
                        continue;
                    }
                    if (!DataValidate.IsIDCardNo(idNo))
                    {
                        result.Errors.Add($"第{i + 1}行：身份证号不合法");
                        continue;
                    }
                    if (string.IsNullOrWhiteSpace(cardNo))
                    {
                        result.Errors.Add($"第{i + 1}行：考勤卡号为空");
                        continue;
                    }
                    if (studentService.isIdNoExisted(idNo))
                    {
                        result.Errors.Add($"第{i + 1}行：身份证号已存在");
                        continue;
                    }
                    if (studentService.isCardNoExisted(cardNo))
                    {
                        result.Errors.Add($"第{i + 1}行：考勤卡号已存在");
                        continue;
                    }

                    int classId = 0;
                    if (headerMap.ContainsKey("classid"))
                    {
                        classId = GetCellInt(row, headerMap["classid"]);
                    }
                    if (classId == 0 && headerMap.ContainsKey("classname"))
                    {
                        string className = GetCellString(row, headerMap["classname"]);
                        if (!string.IsNullOrWhiteSpace(className) && classNameMap.TryGetValue(className, out int mappedId))
                        {
                            classId = mappedId;
                        }
                    }
                    if (classId == 0)
                    {
                        result.Errors.Add($"第{i + 1}行：班级未匹配");
                        continue;
                    }

                    Student student = new Student()
                    {
                        StdName = name,
                        Gender = gender,
                        Birthday = birthday,
                        idNo = idNo,
                        PhoneNumber = phone,
                        Address = address,
                        Classid = classId,
                        Age = age,
                        CardNo = cardNo,
                        StdImage = image
                    };

                    studentService.addNewStd(student);
                    result.Success++;
                }
                catch (Exception ex)
                {
                    result.Errors.Add($"第{i + 1}行：{ex.Message}");
                }
            }

            return result;
        }

        private static IWorkbook CreateWorkbook(string filePath)
        {
            string fileExt = Path.GetExtension(filePath).ToLowerInvariant();
            using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            return fileExt switch
            {
                ".xlsx" => new XSSFWorkbook(fs),
                ".xls" => new HSSFWorkbook(fs),
                _ => throw new ArgumentException("不支持的文件扩展名", nameof(filePath))
            };
        }

        private static Dictionary<string, int> BuildHeaderMap(IRow headerRow)
        {
            Dictionary<string, int> map = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < headerRow.LastCellNum; i++)
            {
                ICell? cell = headerRow.GetCell(i);
                string text = cell?.ToString()?.Trim() ?? string.Empty;
                if (text.Length == 0) continue;
                string key = NormalizeHeader(text);
                if (!map.ContainsKey(key))
                {
                    map[key] = i;
                }
            }
            return map;
        }

        private static string NormalizeHeader(string header)
        {
            return header switch
            {
                "姓名" => "name",
                "StudentName" => "name",
                "StdName" => "name",
                "性别" => "gender",
                "Gender" => "gender",
                "出生日期" => "birthday",
                "Birthday" => "birthday",
                "身份证号" => "idno",
                "身份证号码" => "idno",
                "StudentIdNo" => "idno",
                "idNo" => "idno",
                "考勤卡号" => "cardno",
                "CardNo" => "cardno",
                "联系电话" => "phone",
                "手机号码" => "phone",
                "PhoneNumber" => "phone",
                "家庭住址" => "address",
                "地址" => "address",
                "StudentAddress" => "address",
                "班级ID" => "classid",
                "ClassId" => "classid",
                "所在班级" => "classname",
                "班级" => "classname",
                "ClassName" => "classname",
                "照片" => "image",
                "照片文件名" => "image",
                "StudentImage" => "image",
                "年龄" => "age",
                "Age" => "age",
                _ => header.Trim()
            };
        }

        private static string GetCellString(IRow row, int index)
        {
            ICell? cell = row.GetCell(index);
            if (cell == null) return string.Empty;
            string value;
            if (cell.CellType == CellType.Numeric)
            {
                value = DateUtil.IsCellDateFormatted(cell)
                    ? cell.DateCellValue.ToString("yyyy-MM-dd")
                    : cell.NumericCellValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (cell.CellType == CellType.Boolean)
            {
                value = cell.BooleanCellValue ? "1" : "0";
            }
            else
            {
                value = cell.ToString() ?? string.Empty;
            }
            return value.Trim();
        }

        private static DateTime GetCellDate(IRow row, int index)
        {
            ICell? cell = row.GetCell(index);
            if (cell == null) throw new Exception("出生日期为空");
            if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
            {
                return cell.DateCellValue.Date;
            }
            string text = cell.ToString() ?? string.Empty;
            if (DateTime.TryParse(text, out DateTime date))
            {
                return date.Date;
            }
            if (DateTime.TryParseExact(text, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime exact))
            {
                return exact.Date;
            }
            throw new Exception("出生日期格式不正确");
        }

        private static int GetCellInt(IRow row, int index)
        {
            string text = GetCellString(row, index);
            if (int.TryParse(text, out int val)) return val;
            return 0;
        }

        private static int CalculateAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (birthday.Date > DateTime.Now.AddYears(-age)) age--;
            return age;
        }

        private static string NormalizeGender(string gender)
        {
            string g = gender.Trim().ToLowerInvariant();
            if (g == "男" || g == "m" || g == "male") return "男";
            if (g == "女" || g == "f" || g == "female") return "女";
            return string.Empty;
        }

        private static bool IsRowEmpty(IRow row)
        {
            for (int i = row.FirstCellNum; i < row.LastCellNum; i++)
            {
                if (!string.IsNullOrWhiteSpace(row.GetCell(i)?.ToString())) return false;
            }
            return true;
        }
    }
}
