using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ahutit
{
    public class NPOIService
    {
        public static bool ExportToExcel<T>(string fileName, List<T> dataList, Dictionary<string, string> columnNames, int sheetIndex)
        {
            // TODO: 实现 Excel 导出逻辑
            // 需要添加 NPOI NuGet 包来实现 Excel 导出功能
            throw new NotImplementedException("ExportToExcel 方法尚未实现");
        }
    }
}
