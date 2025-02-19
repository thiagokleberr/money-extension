namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShoudConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27998, cents);
    }
}
