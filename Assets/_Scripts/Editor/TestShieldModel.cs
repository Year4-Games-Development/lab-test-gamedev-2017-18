using NUnit.Framework;

public class TestShieldModel {

	[Test]
	public void TestWhenCreatedStrengthOneHundred ()
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 100;

		// Act
		int result = sm.GetStrength ();

		//Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedRepairQuantityTen () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 10;

		// Act
		int result = sm.RepairQuantity;

		//Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedRepairThresholdTwentyFive ()
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 25;

		// Act
		int result = sm.RepairableThreshold;

		// Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedIsRepairableReturnsTrue () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();

		// Act
		bool isRepairableStatus = sm.IsRepairable ();

		// Assert
		Assert.True (isRepairableStatus);
	}

	[Test]
	public void TestAfterOneDamageOfOneIsRepairableTrueAndStrengthNinetyNine () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 1;
		int expectedResult = 99;

		// Act
		bool takeDamage = sm.TakeDamage(damage);
		int result = sm.GetStrength ();
		bool isRepairableStatus = sm.IsRepairable ();

		// Assert
		Assert.AreEqual(expectedResult, result);
		Assert.True (isRepairableStatus);
	}

	[Test]
	public void TestAfterOneDamageOfTenIsRepairableTrueAndStrengthNinety () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 10;
		int expectedResult = 90;

		// Act
		bool takeDamage = sm.TakeDamage(damage);
		int result = sm.GetStrength ();
		bool isRepairableStatus = sm.IsRepairable ();

		// Assert
		Assert.AreEqual(expectedResult, result);
		Assert.True (isRepairableStatus);
	}

	[Test]
	public void TestAfterEightDamageOfTenIsRepairableFalseAndStrengthTwenty () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 10;
		int expectedResult = 20;

		// Act
		bool takeDamage1 = sm.TakeDamage(damage);
		bool takeDamage2 = sm.TakeDamage(damage);
		bool takeDamage3 = sm.TakeDamage(damage);
		bool takeDamage4 = sm.TakeDamage(damage);
		bool takeDamage5 = sm.TakeDamage(damage);
		bool takeDamage6 = sm.TakeDamage(damage);
		bool takeDamage7 = sm.TakeDamage(damage);
		bool takeDamage8 = sm.TakeDamage(damage);
		int result = sm.GetStrength ();
		bool isRepairableStatus = sm.IsRepairable ();

		// Assert
		Assert.AreEqual(expectedResult, result);
		Assert.False (isRepairableStatus);
	}

	[Test]
	public void TestAfterOneDamageOfNinetyIsRepairableFalseAndStrengthTen () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 90;
		int expectedResult = 10;

		// Act
		bool takeDamage = sm.TakeDamage(damage);
		int result = sm.GetStrength ();
		bool isRepairableStatus = sm.IsRepairable ();

		// Assert
		Assert.AreEqual(expectedResult, result);
		Assert.False (isRepairableStatus);
	}

	[Test]
	public void TestAfterOneDamageOfElevenAndOneTickStengthNinetyNine () 
	{
		// Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 11;
		int expectedResult = 99;

		// Act
		bool takeDamage = sm.TakeDamage(damage);
		sm.Tick ();
		int result = sm.GetStrength ();
		// Assert
		Assert.AreEqual(expectedResult, result);
	}
}
