# [BerkC.DictionaryToExcelWithTabSheets](https://www.nuget.org/packages/BerkC.DictionaryToExcelWithTabSheets/1.0.0) [![NuGet version](https://badge.fury.io/nu/BerkC.DictionaryToExcelWithTabSheets.svg)](https://badge.fury.io/nu/BerkC.DictionaryToExcelWithTabSheets)

Create Excel from Dictionary With Tab Sheets
Forked from https://github.com/ugurhangul/DictionaryToExcel Thanks to Ugurhan Gul
And also thanks to Leonid Salavatov https://github.com/mustaddon/ArrayToExcel 

### Example 

```C#
var documentName = "New Document";
var firstTabName = "First Tab Name";

List<TabSheet> listOfTabSheet = new();
TabSheet tabSheet = new();
tabSheet.Name = "Second Tab Name";

Dictionary<string, string> property = new();
property.Add("Second Tab First Title", "Second Tab Second Title");
property.Add("Second Tab Second Column First Row Content", "Second Tab Second Column Second Row Content");
tabSheet.Properties.Add(property);
listOfTabSheet.Add(tabSheet);

List<Dictionary<string, string>> list = new();
Dictionary<string, string> dic = new();

dic.Add("First Tab First Title", "First Tab Second Title");
dic.Add("First Tab Second Column First Row Content", "First Tab Second Column Second Row Content");
list.Add(dic);

list.ToExcel(firstTabName, listOfTabSheet);
```