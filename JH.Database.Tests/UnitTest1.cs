namespace JH.Database.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var record = "Books";
        var data ="Testing if it works";
        var topic = "Thriller";
        var writer = new Writing();
        writer.First_function(record,data,topic);

    }
}