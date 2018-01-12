using NUnit.Framework;

[TestFixture]
public class ShieldModelTest
{
	[Test]
	public void PostConstructorStrengthIsOneHundredTest()
	{
		ShieldModel sm = new ShieldModel ();
		Assert.AreEqual (100, sm.GetStrength ());
	}

	[Test]
	public void PostConstructorRepairQuantityIsTenTest()
	{
		ShieldModel sm = new ShieldModel ();
		Assert.AreEqual (10, sm.RepairQuantity);
	}

	[Test]
	public void PostConstructorRepairTresholdIsTwentyFiveTest()
	{
		ShieldModel sm = new ShieldModel ();
		Assert.AreEqual (25, sm.RepairableThreshold);
	}

	[Test]
	public void PostConstructorIsRepairableReturnsTrueTest()
	{
		ShieldModel sm = new ShieldModel ();
		Assert.IsTrue (sm.IsRepairable ());
	}

	[Test]
	public void OneDamageOfOneActionTest()
	{
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (1);
		Assert.AreEqual (99, sm.GetStrength ());
		Assert.IsTrue (sm.IsRepairable ());
	}

	[Test]
	public void OneDamageOfTenActionTest()
	{
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (10);
		Assert.AreEqual (90, sm.GetStrength ());
		Assert.IsTrue (sm.IsRepairable ());
	}

	[Test]
	public void EightDamageOfTenActionTest()
	{
		ShieldModel sm = new ShieldModel ();
		for (int i = 0; i < 8; i++)
			sm.TakeDamage (10);
		Assert.AreEqual (20, sm.GetStrength ());
		Assert.IsFalse (sm.IsRepairable ());
	}

	[Test]
	public void OneDamageOfNinetyActionTest()
	{
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (90);
		Assert.AreEqual (10, sm.GetStrength ());
		Assert.IsFalse (sm.IsRepairable ());
	}

	[Test]
	public void OneDamageOfElevenAndOneTickActionTest()
	{
		ShieldModel sm = new ShieldModel ();
		sm.TakeDamage (11);
		sm.Tick ();
		Assert.AreEqual (99, sm.GetStrength ());
	}
}
