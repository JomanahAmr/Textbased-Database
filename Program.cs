using System.Text.Json;
Console.WriteLine("Create table? (y/n)");
string response = Console.ReadLine();
int auto=0;
int part=0;
if(response=="y"){
    Console.WriteLine("Write a name for the table");
    string tableName = Console.ReadLine();
    Console.WriteLine("Write an ID or Choose autogeneration(write/generate)");
    string choice = Console.ReadLine();
    string ID=" ";
    if(choice=="generate"){  
        auto++;
         ID = ($"auto{auto}");
        Console.WriteLine($"your ID is {ID}");
        // ID won't be remembered so fix that
    }
    else if(choice=="write"){
        Console.WriteLine("Write an ID ");
        //I Need to remember to put constrains Here
         ID = Console.ReadLine();
        Console.WriteLine($"your ID is {ID}");
    }
    var partitions = new List<object>();
    string anotherAttri;
    do{
    part++;
    string partID=($"PA{part}");
    Console.WriteLine($"Partition ID is {partID}");
    // ID won't be remembered so fix that
    
    Dictionary<string,string> attributes = new Dictionary<string,string>();
    partitions.Add(new { PID = partID, allattributes = attributes });
    do{
    Console.WriteLine("Write attribute Name and then space then the data");
    string TotalInput = Console.ReadLine();
    string[] WholeData = TotalInput.Split(' ',2);
    string AttributeName = WholeData[0];
    string AttributeData = WholeData[1];
    attributes[AttributeName]=AttributeData;
    Console.WriteLine("Save or Write another attribute or make another partition(Save/Write/partition)");
    anotherAttri = Console.ReadLine();}while (anotherAttri=="Write"|| anotherAttri=="write");
    if(anotherAttri=="Save" || anotherAttri=="save" ){
        var TheRecord= new {TName=tableName,MainID=ID,partitions=partitions};
        string TypeJson = JsonSerializer.Serialize(TheRecord);
        string FileName= $"{ID}.json";
        File.WriteAllText(FileName,TypeJson);
        Console.WriteLine("Saved!");
    }}while(anotherAttri=="partition");
     
}
else if (response=="n"){
Console.WriteLine("Goodbye!");
}

//remember to put constrains 
//remember to put it in a class
