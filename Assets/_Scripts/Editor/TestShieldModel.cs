using NUnit.Framework;

public class TestShieldModel {

	//File could not find strength for some reason?
	public void TestStrentIsOneHunderd()
	{
		//Arrange
		//ShieldModel sm = new ShieldModel();
		//int expectedResult = 100;

		//Act
		//int result = sm.strength;

		// Assert
//	Assert.AreEqual (expectedResult, result);
	}

	public void TestRepairQuantityIsTen()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 10;

		//Act
		int result = sm.RepairQuantity;

		// Assert
		Assert.AreEqual (expectedResult, result);
	}

	public void TestRepairThresholdIsTwentyFive()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 25;

		//Act
		int result = sm.RepairableThreshold;

		// Assert
		Assert.AreEqual (expectedResult, result);
	}

	public void TestISRepairAbleReturnTrue()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();

		//Act
		bool result = sm.IsRepairable();

		// Assert
		Assert.True(result);
	}

	public void TestAfterOneDamageISRepairableTrueAndStrength99()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int damageDealt = 1;
		int expectedResult = 99;

		//Act
		bool damageSuccess = sm.TakeDamage(damageDealt);
		int result = sm.GetStrength ();

		// Assert
		Assert.True(damageSuccess);
		Assert.AreEqual (expectedResult, result);
	}

	public void TestAfterTenDamageISRepairableTrueAndStrength90()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int damageDealt = 10;
		int expectedResult = 90;

		//Act
		bool damageSuccess = sm.TakeDamage(damageDealt);
		int result = sm.GetStrength ();

		// Assert
		Assert.True(damageSuccess);
		Assert.AreEqual (expectedResult, result);
	}

	public void TestAfterFourDamageOfTenISRepairableFalseAndStrength20()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int damageDealt = 10;
		int expectedResult = 20;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageDealt);
		bool damageSuccess2 = sm.TakeDamage(damageDealt);
		bool damageSuccess3 = sm.TakeDamage(damageDealt);
		bool damageSuccess4 = sm.TakeDamage(damageDealt);
		bool damageSuccess5 = sm.TakeDamage(damageDealt);
		bool damageSuccess6 = sm.TakeDamage(damageDealt);
		bool damageSuccess7 = sm.TakeDamage(damageDealt);
		bool damageSuccess8 = sm.TakeDamage(damageDealt);
		bool isRepairable = sm.IsRepairable();
		int result = sm.GetStrength ();

		// Assert
		Assert.False(isRepairable);
		Assert.AreEqual (expectedResult, result);
	}

	public void TestOneDamageOf90ISRepairableFalseAndStrength10()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int damageDealt = 90;
		int expectedResult = 10;

		//Act
		bool damageSuccess = sm.TakeDamage(damageDealt);
		int result = sm.GetStrength ();

		// Assert
		Assert.False(damageSuccess);
		Assert.AreEqual (expectedResult, result);
	}

	public void TestOneDamageOf11AndOneTickStrengthIs99()
	{
		//Arrange
		ShieldModel sm = new ShieldModel();
		int damageDealt = 11;
		int expectedResult = 99;

		//Act
		bool damageSuccess = sm.TakeDamage(damageDealt);
		//bool tickSuccess = sm.Tick ();
		int result = sm.GetStrength ();

		// Assert
		Assert.AreEqual (expectedResult, result);
	}


		
	}
