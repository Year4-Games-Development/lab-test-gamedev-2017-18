//Test Storage Model

using NUnit.Framework;

public class TestShieldModel {
    [Test]
    public void TestStrengthIs100()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int expectedResult = 100;

        //Act
        int result = sm.GetStrength();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void TestRepairQuantityIs10()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int expectedResult = 10;

        //Act
        int result = sm.RepairQuantity;

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void TestRepairThresholdis25()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int expectedResult = 25;

        //Act
        int result = sm.RepairableThreshold;

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    
    [Test]
    public void TestIsRepairableReturnsTrue()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();

        //Act
        bool result = sm.IsRepairable();

        //Assert
        Assert.True(result);
    }

    [Test]
    public void TestAfterDamageOneIsTrue()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int damageQuantity = 1;
        int expectedResult = 99;

        //Act
        bool damageSuccess = sm.TakeDamage(damageQuantity);
        int result = sm.GetStrength();

        //Assert
        Assert.True(damageSuccess);
        Assert.AreEqual(expectedResult, result);

    }

    [Test]
    public void TestAfterDamageOneOfTenIsTrue()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int damageQuantity = 10;
        int expectedResult = 90;

        //Act
        bool damageSuccess = sm.TakeDamage(damageQuantity);
        int result = sm.GetStrength();

        //Assert
        Assert.True(damageSuccess);
        Assert.AreEqual(expectedResult, result);

    }

    [Test]
    public void TestAfterDamageEightOfTenIsTrue()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int damageQuantity = 10*8;
        int expectedResult = 20;

        //Act
        bool damageSuccess = sm.TakeDamage(damageQuantity);
        int result = sm.GetStrength();

        //Assert
        Assert.False(damageSuccess);
        Assert.AreEqual(expectedResult, result);

    }

    [Test]
    public void TestAfterDamageOneOfNinetyIsTrue()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int damageQuantity = 90;
        int expectedResult = sm.GetStrength();

        //Act
        bool damageSuccess = sm.TakeDamage(damageQuantity);
        int result = sm.GetStrength();

        //Assert
        Assert.False(damageSuccess);
        Assert.AreEqual(expectedResult, result);

    }
    /*
    [Test]
    public void TestAfterDamageOneOf11IsTick()
    {
        //Arrange
        ShieldModel sm = new ShieldModel();
        int damageTick = 1;
        int damageQuantity = 11;
        int expectedResult = 99;

        //Act
        bool damageSuccess = sm.TakeDamage(damageQuantity);
        int tickSuccess = sm.Tick(damageTick);
        int result = sm.GetStrength();

        //Assert
        Assert.False(damageSuccess && tickSuccess);
        Assert.AreEqual(expectedResult, result);

    }*/

}
