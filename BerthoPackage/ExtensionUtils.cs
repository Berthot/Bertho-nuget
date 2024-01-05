namespace BerthoPackage;

public static class ExtensionUtils
{
    public static Guid ToGuid(this int value)
    {
        var bytes = new byte[16];
        BitConverter.GetBytes(value).CopyTo(bytes, 0);
        return new Guid(bytes);
    }
    
    public static Guid ToGuid(this string value)
    {
        var tryParse = Guid.TryParse(value, out var guid);
        if (tryParse == false)
            throw new Exception($"The guid [ {value} ] could not be converted");
        return guid;
    }
}