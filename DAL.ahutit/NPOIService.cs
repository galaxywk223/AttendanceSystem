using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace DAL.ahutit
{
    public class NPOIService
    {
        public static bool ExportToExcel<T>(string fileName, List<T> dataList, Dictionary<string, string> columnNames, int sheetIndex = 0)
        {
            try
            {
                IWorkbook workbook;
                string fileExt = Path.GetExtension(fileName).ToLower();
                if (fileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook();
                }
                else if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook();
                }
                else
                {
                    workbook = null;
                    return false;
                }

                ISheet sheet = workbook.CreateSheet("Sheet1");
                IRow headerRow = sheet.CreateRow(0);

                // Create Header
                int colIndex = 0;
                foreach (var colName in columnNames)
                {
                    headerRow.CreateCell(colIndex).SetCellValue(colName.Value);
                    colIndex++;
                }

                // Fill Data
                int rowIndex = 1;
                foreach (T item in dataList)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);
                    colIndex = 0;
                    Type type = typeof(T);
                    foreach (var colName in columnNames)
                    {
                        PropertyInfo? prop = type.GetProperty(colName.Key);
                        if (prop != null)
                        {
                            object? value = prop.GetValue(item, null);
                            if (value != null)
                            {
                                if (value is DateTime)
                                {
                                    dataRow.CreateCell(colIndex).SetCellValue(((DateTime)value).ToString("yyyy-MM-dd"));
                                }
                                else
                                {
                                    dataRow.CreateCell(colIndex).SetCellValue(value.ToString());
                                }
                            }
                        }
                        colIndex++;
                    }
                    rowIndex++;
                }

                // Auto Size Columns
                for (int i = 0; i < columnNames.Count; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                // Write to File
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Export to Excel failed: " + ex.Message);
            }
        }
    }
}
