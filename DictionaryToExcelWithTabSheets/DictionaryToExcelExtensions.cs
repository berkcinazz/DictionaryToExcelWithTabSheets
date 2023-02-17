using BerkC.DictionaryToExcelWithTabSheets.Entities;
using System.Collections.Generic;

namespace BerkC.DictionaryToExcelWithTabSheets
{
    public static class DictionaryToExcelExtensions
    {
        public static byte[] ToExcel<T>(this T items, string firstTabName = "Sheet1", List<TabSheet> tabSheets = null) where T : List<Dictionary<string, string>>
        {
            return DictionaryToExcel.CreateExcel(items, firstTabName, tabSheets);
        }

        //public static byte[] ToExcel<T>(this T items, Action<DictionaryToExcelScheme<T>> schemeBuilder) where T : List<Dictionary<string, string>>
        //{
        //    return DictionaryToExcel.CreateExcel(items, schemeBuilder);
        //}

    }
}
