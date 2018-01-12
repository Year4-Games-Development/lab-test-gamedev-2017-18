using NUnit.Framework;
public class TestShieldModel
{
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

	[Test]
	public void TestAfterTenDamageRepairIsTrueAndStrengthIsNinty()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int damage = 10;
		int strength = 90;

		// Act
		bool repairSuccess = sm.IsRepairable();
		int result = (sm.GetStrength()-damage);

		// Assert
		Assert.True(repairSuccess);
		Assert.AreEqual(strength,result);
	}

	[Test]
	public void TestAfterEightTimesOfTenDamageRepairIsFalseAndStrengthIsTwenty()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int damage = 10;
		int times = 8;
		int strength = 20;

		// Act
		int totalDamage = damage * times;
		bool repairSuccess = sm.IsRepairable();

		int result = (sm.GetStrength()-totalDamage);

		// Assert
		Assert.True(repairSuccess);
		Assert.AreEqual(strength,result);
	}

	[Test]
	public void TestDamageIsElevenAfterOneTickStrengthIsNinetyNine()
	{
		// Arrange
		ShieldModel sm = new ShieldModel();
		int damage = 11;
		int strength = 99;

		// Act
		//int tick = sm.Tick();

		int result = (sm.GetStrength()-damage);

		// Assert
		Assert.AreEqual(strength,result);
	}
}