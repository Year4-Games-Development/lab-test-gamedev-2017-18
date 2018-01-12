using NUnit.Framework;

public class TestShieldModel
{
	[Test]
	public void TestStrengthReturnsOnehundred()
	{

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 100;

		//Act
		int result = sm.GetStrength(); 

		//Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestRepairQuantityReturnsTen()
	{

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 10;

		//Act
		int result = sm.RepairQuantity; 

		//Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestRepairThresholdReturnstwentyfive()
	{

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 25;

		//Act
		int result = sm.RepairableThreshold; 

		//Assert
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestIsRepairableReturnsTrue()
	{

		//Arrange
		ShieldModel sm = new ShieldModel ();


		//Act
		bool result = sm.IsRepairable(); 

		//Assert
		Assert.IsTrue(result);
	}

	[Test]
	public void TestOneDamageOfOne()
	{
		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 1;
		bool repairable= sm.TakeDamage(damage); 
		int expectedResult = sm.GetStrength();

		//Act
		int result = sm.GetStrength();

		//Assert
		Assert.IsTrue(repairable);
		Assert.AreEqual (expectedResult, result);
	}

	[Test]
	public void TestOneDamageOfTen()
	{
		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 10;
		bool repairable= sm.TakeDamage(damage); 
		int expectedResult = sm.GetStrength();

		//Act

		int result = sm.GetStrength();
	

		//Assert
		Assert.IsTrue(repairable);
		Assert.AreEqual (expectedResult, result);
	}


	[Test]
	public void TestEightDamageOfTen()
	{
		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damage = 10;

		bool damage1= sm.TakeDamage(damage*8); 
		int expectedResult = sm.GetStrength();
			
		//Act
		int result = sm.GetStrength();
		bool repairable = sm.IsRepairable ();
			
		//Assert
		Assert.IsFalse(repairable);
		Assert.AreEqual ( result,expectedResult);
	}
}
