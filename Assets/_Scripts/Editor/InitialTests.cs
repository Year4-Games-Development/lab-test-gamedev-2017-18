using NUnit.Framework;

public class initialTests
{
    [Test]
    public void InitialStrength()
    {
        ShieldModel sm = new ShieldModel();
        int expectedStrength = 100;

        int result = sm.GetStrength();

        Assert.AreEqual(expectedStrength, result);
    }

    [Test]
    public void InitialRepairQuantity()
    {
        ShieldModel sm = new ShieldModel();
        int expectedRepairQuantity = 10;

        int result = sm.GetRepairQuantity();

        Assert.AreEqual(expectedRepairQuantity, result);
    }

    [Test]
    public void InitialRepairThreshold()
    {
        ShieldModel sm = new ShieldModel();
        int expectedRepairableThreshold = 25;

        int result = sm.GetRepairableThreshold();

        Assert.AreEqual(expectedRepairableThreshold, result);
    }

    [Test]
    public void IsRepairableTest()
    {
        ShieldModel sm = new ShieldModel();
     
        Assert.True(sm.IsRepairable());
    }

}
