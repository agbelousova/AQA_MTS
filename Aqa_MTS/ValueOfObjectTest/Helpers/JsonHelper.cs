using System.Text.Json;
using ValueOfObjectTest.Models;

namespace ValueOfObjectTest.Helpers;

public static class JsonHelper
{
    public static JsonObject1 FromJson(string path)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        return JsonSerializer.Deserialize<JsonObject1>(fs);
    } 

    public static string ToJson(JsonObject1 obj)
    {
        return JsonSerializer.Serialize(obj);
    } 

    public static Project ProjectFromJson(string path)
    {
        using FileStream fs = new FileStream(path, FileMode.Open);
        return JsonSerializer.Deserialize<Project>(fs);
    } 

    public static string ToJson(Project obj)
    {
        return JsonSerializer.Serialize(obj);
    } 
}