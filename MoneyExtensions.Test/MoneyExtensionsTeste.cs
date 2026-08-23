namespace MoneyExtensions.Test;


public class MoneyExtensionsTeste
{
    [Fact]
    public void Should_Convert_Decimal_In_Money()
    {
        decimal value = 20.20m;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
    [Fact]
    public void Should_Convert_Float_In_Money()
    {
        float value = 20.2f;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
    [Fact]
    public void Should_Convert_Double_In_Money()
    {
        double value = 19.90;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
    [Fact]
    public void Should_Convert_Int_In_Money()
    {
        int value = 10;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
    [Fact]
    public void Should_Convert_Short_In_Money()
    {
        short value = 30;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
    [Fact]
    public void Should_Convert_Byte_In_Money()
    {
        byte value = 20;
        
        string result = value.ToMoney();
        
        Assert.Equal(value.ToString("C"),result);
    }
}