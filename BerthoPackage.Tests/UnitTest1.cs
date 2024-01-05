namespace BerthoPackage.Tests;

public class ExtensionUtilsTests
{
    private readonly string _guidString = "00000001-0000-0000-0000-000000000000";

    [Test]
    public void ConvertANumberToGuid_convert_withoutError()
    {
        Assert.That(1.ToGuid().ToString(), Is.EqualTo(_guidString));
    }
    
    [Test]
    public void ConvertStringToGuid_convert_withoutError()
    {
        Assert.That(_guidString.ToGuid(), Is.EqualTo(1.ToGuid()));
    }
}