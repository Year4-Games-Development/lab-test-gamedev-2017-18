using NUnit.Framework;

public class TestShieldModel
{
	[Test]
	public void TestWhenCreatedStrengthOnehundred()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 100;

		//Act
		int result = sm.GetStrength();

		//assert
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedRepairQuantityTen()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 10;

		//Act
		int result = sm.RepairQuantity;

		//assert
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedRepairThresholdTwentyfive()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int expectedResult = 25;

		//Act
		int result = sm.RepairableThreshold;

		//assert
		Assert.AreEqual(expectedResult, result);
	}

	[Test]
	public void TestWhenCreatedIsRepairAbleTrue()
	{
		//Arange
		ShieldModel sm = new ShieldModel();

		//Act
		bool result = sm.IsRepairable();

		//assert
		Assert.True(result);
	}

	[Test]
	public void TestAfterDamageOneAndIsRepairableTrueAndStrengthNinetyNine()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int damage = 1;
		int expectedResult = 99;

		//Act
		bool result = sm.IsRepairable();
		sm.TakeDamage (damage);
		int strength = sm.GetStrength();

		//assert
		Assert.True(result);
		Assert.AreEqual (expectedResult, strength);
	}

	[Test]
	public void TestAfterDamageTenAndIsRepairableTrueAndStrengthNinety()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int damage = 10;
		int expectedResult = 90;

		//Act
		bool result = sm.IsRepairable();
		sm.TakeDamage (damage);
		int strength = sm.GetStrength();

		//assert
		Assert.True(result);
		Assert.AreEqual (expectedResult, strength);
	}

	[Test]
	public void TestAfterEightDamageTenAndIsRepairableFalseAndStrengthTwenty()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int damage = 10;
		int expectedResult = 20;

		//Act
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		sm.TakeDamage (damage);
		bool result = sm.IsRepairable();
		int strength = sm.GetStrength();

		//assert
		Assert.False(result);
		Assert.AreEqual (expectedResult, strength);
	}

	[Test]
	public void TestAfterDamageNinetyAndIsRepairableFalseAndStrengthTen()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int damage = 90;
		int expectedResult = 10;

		//Act
		sm.TakeDamage (damage);
		bool result = sm.IsRepairable();
		int strength = sm.GetStrength();

		//assert
		Assert.False(result);
		Assert.AreEqual (expectedResult, strength);
	}

	[Test]
	public void TestAfterDamageElevenAndTickOneAndStrengthNinetyNine()
	{
		//Arange
		ShieldModel sm = new ShieldModel();
		int damage = 11;
		int expectedResult = 99;

		//Act
		sm.TakeDamage (damage);
		sm.Tick ();
		int strength = sm.GetStrength();

		//assert
		Assert.AreEqual (expectedResult, strength);
	}
}
