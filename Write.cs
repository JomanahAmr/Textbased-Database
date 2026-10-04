namespace Write;
using System;
using System.IO;
public class Writing{
    string Path_Name ="database";
    public void First_function(string topic,string data,string record){
        var file = Path.Combine(Path_Name,record,topic);
        Directory.CreateDirectory(Path.Combine(Path_Name,record));
        File.AppendAllText(file,data + Environment.NewLine);
    }
}