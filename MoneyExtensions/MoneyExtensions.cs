namespace MoneyExtensions;

public static class Extensions
{
    public static string ToMoney(this decimal value)
        => value.ToString("C");
    public static string ToMoney(this double value)
            => value.ToString("C");
    public static string ToMoney(this float value)
            => value.ToString("C");
    public static string ToMoney(this byte value)
        => value.ToString("C");
    public static string ToMoney(this sbyte value)
        => value.ToString("C");
    
    public static string ToMoney(this uint value)
            => value.ToString("C");
    public static string ToMoney(this int value)
        => value.ToString("C");
    
    public static string ToMoney(this ushort value)
        => value.ToString("C");
    public static string ToMoney(this short value)
        => value.ToString("C");
    
    public static string ToMoney(this ulong value)
        => value.ToString("C");
    public static string ToMoney(this long value)
        => value.ToString("C");
}