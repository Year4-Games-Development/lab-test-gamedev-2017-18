using NUnit.Framework;

public class PostActionTests
{

    [Test]
    public void After1DamageTest()
    {
        ShieldModel sm = new ShieldModel();

        int expectedStrength = 99;

        sm.TakeDamage(1);//damage by 1

        int result = sm.GetStrength();

        Assert.True(sm.IsRepairable());
        Assert.AreEqual(expectedStrength, result);
    }

    [Test]
    public void After10DamageTest()
    {
        ShieldModel sm = new ShieldModel();

        int expectedStrength = 90;

        sm.TakeDamage(10);//damage by 10

        int result = sm.GetStrength();

        Assert.True(sm.IsRepairable());
        Assert.AreEqual(expectedStrength, result);
    }

    [Test]
    public void After80DamageTest()
    {
        ShieldModel sm = new ShieldModel();

        int expectedStrength = 20;

        sm.TakeDamage(80);//damage by 80

        int result = sm.GetStrength();

        Assert.False(sm.IsRepairable());
        Assert.AreEqual(expectedStrength, result);
    }

    [Test]
    public void After90DamageTest()
    {
        ShieldModel sm = new ShieldModel();

        int expectedStrength = 10;

        sm.TakeDamage(90);//damage by 90

        int result = sm.GetStrength();

        Assert.False(sm.IsRepairable());
        Assert.AreEqual(expectedStrength, result);
    }

    [Test]
    public void After11DamageTest()
    {
        ShieldModel sm = new ShieldModel();

        int expectedStrength = 99;

        sm.TakeDamage(11);//damage by 11

        sm.Tick();//repair by 10

        int result = sm.GetStrength();

        Assert.AreEqual(expectedStrength, result);
    }

}
