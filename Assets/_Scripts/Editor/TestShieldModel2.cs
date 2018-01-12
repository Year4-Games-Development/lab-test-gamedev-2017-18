using NUnit.Framework;
public class TestShieldModel2
{


	/*
	[Test]
	public void TestAfterOneDamageRepairIsTrueAndStrengthIsNintyNine()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int damage = 1;
		int strength = 99;

		// Act
		bool repairSuccess = sm.IsRepairable();
		int result = (sm.GetStrength()-damage);

		// Assert
		Assert.True(repairSuccess);
		Assert.AreEqual(strength,result);
	}



	*/


	[Test]
	public void TestAfter1DamageRepairIsTrueAndStrengthIs99Version2()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int damage = 1;
		int strength = 99;

		// Act
		bool repairSuccess = sm.IsRepairable();
		//int result = (sm.GetStrength()-damage);
		int result = sm.TakeDamage(damage);

		// Assert
		Assert.True(repairSuccess);
		Assert.AreEqual(strength,result);
	}


	[Test]
	public void TestStrengthIsOneHundred()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 100;

		// Act
		int result = sm.GetStrength ();

		// Assert
		Assert.AreEqual (expectedResult, result);
	}



	[Test]
	public void TestRepairQuantityIsTen()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 10;

		// Act
		int result = sm.RepairQuantity;

		// Assert
		Assert.AreEqual (expectedResult, result);
	}

	/*

	[Test]
	public void TestRepairthresholdIsTwentyFive()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 25;

		// Act
		int result = sm.RepairableThreshold;

		// Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestIsRepairableIsTrue()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();

		// Act
		bool result = sm.IsRepairable();

		// Assert
		Assert.True(result);
	}

*/

}