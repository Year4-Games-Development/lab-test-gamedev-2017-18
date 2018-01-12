using NUnit.Framework;
public class TestShieldModel2
{
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
}