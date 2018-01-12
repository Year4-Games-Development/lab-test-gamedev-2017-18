using NUnit.Framework;

public class TestShieldModel {

	/// <summary>
	/// Question 2
	/// </summary>
	[Test]
	public void TestWhenStrengthOneHundred() {

		//Arrange
		ShieldModel sm = new ShieldModel ();

		int expectedResult = 100;

		//Act
		int result = sm.GetStrength();

		//Assert
		Assert.AreEqual(expectedResult, result);

	}


	[Test]
	public void TestWhenRepairQuantityTen() {

		//Arrange
		ShieldModel sm = new ShieldModel ();

		int expectedResult = 10;

		//Act
		int result = sm.RepairQuantity;

		//Assert
		Assert.AreEqual(expectedResult, result);

	}

	[Test]
	public void TestWhenRepairThresholdTwentyFive() {

		//Arrange
		ShieldModel sm = new ShieldModel ();

		int expectedResult = 25;

		//Act
		int result = sm.RepairableThreshold;

		//Assert
		Assert.AreEqual(expectedResult, result);

	}


	[Test]
	public void TestWhenIsRepairAbleTrue() {

		//Arrange
		ShieldModel sm = new ShieldModel ();

		//Act
		bool result = sm.IsRepairable();

		//Assert
		Assert.True(result);

	}

	/// <summary>
	/// Question 3
	/// </summary>

	[Test]
	public void TestAfterOneDamageOneReturnTrue() {

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damageQuantity = 1;
		int expectedResult = 99;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageQuantity);

		int result = sm.GetStrength ();

		//Assert
		Assert.True(damageSuccess1);
		Assert.AreEqual(expectedResult, result);

	}

	[Test]
	public void TestAfterOneDamageTenReturnTrue() {

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damageQuantity = 10;
		int expectedResult = 90;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageQuantity);

		int result = sm.GetStrength ();

		//Assert
		Assert.True(damageSuccess1);
		Assert.AreEqual(expectedResult, result);

	}

	[Test]
	public void TestAfterEightDamageTenReturnFalse() {

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damageQuantity = 10;
		int expectedResult = 20;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageQuantity);
		bool damageSuccess2 = sm.TakeDamage(damageQuantity);
		bool damageSuccess3 = sm.TakeDamage(damageQuantity);
		bool damageSuccess4 = sm.TakeDamage(damageQuantity);
		bool damageSuccess5 = sm.TakeDamage(damageQuantity);
		bool damageSuccess6 = sm.TakeDamage(damageQuantity);
		bool damageSuccess7 = sm.TakeDamage(damageQuantity);
		bool damageSuccess8 = sm.TakeDamage(damageQuantity);

		bool damageSuccess = sm.TakeDamage(damageQuantity);

		int result = sm.GetStrength ();

		//Assert
		Assert.False(sm.TakeDamage(damageQuantity));
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestAfterOneDamageNinetyReturnFalse() {

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damageQuantity = 90;
		int expectedResult = 20;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageQuantity);

		int result = sm.GetStrength ();

		//Assert
		Assert.False(sm.TakeDamage(damageQuantity));
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestAfterOneDamageOneTickReturnTrue() {

		//Arrange
		ShieldModel sm = new ShieldModel ();
		int damageQuantity = 11;
		int expectedResult = 99;

		//Act
		bool damageSuccess1 = sm.TakeDamage(damageQuantity);

		int result = sm.GetStrength ();

		//Assert
		Assert.True(sm.TakeDamage(damageQuantity));
		Assert.AreEqual(expectedResult, result);
	}

}
