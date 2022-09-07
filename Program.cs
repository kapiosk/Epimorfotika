using CsvHelper;
using Epimorfotika;
using System.Net.Http.Json;
using System.Text;
var url = "https://eforms.schools.ac.cy/index.php/index.php?option=com_droptables&task=loadData&view=ajax&tmpl=component&format=json&id=9&page=1&size=&filter&column[0]=1";
using HttpClient client = new();
var value =await client.GetFromJsonAsync<Data>(url);
//var data = File.ReadAllText("rawdata.json");
//var value = System.Text.Json.JsonSerializer.Deserialize<Data>(data);
if (value is not null)
{
    using StreamWriter sr = new("epimorfotika.csv", false, Encoding.UTF8);
    using CsvWriter csv = new(sr, new(System.Globalization.CultureInfo.InvariantCulture));
    csv.WriteRecords(value.Rows);
}