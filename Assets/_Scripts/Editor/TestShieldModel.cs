using NUnit.Framework;

public class TestShieldModel {
	[Test]
	public void TestWhenCreatedStrength100(){
		ShieldModel sm = new ShieldModel ();
		int expected = 100;

		int result = sm.GetStrength ();

		Assert.AreEqual (expected, result);
	}

	[Test]
	public void TestWhenCreatedRepairQuantity10(){
		ShieldModel sm = new ShieldModel ();
		int expected = 10;

		int result = sm.RepairQuantity;

		Assert.AreEqual (expected, result);
	}

	[Test]
	public void TestWhenCreatedRepairThreshold25(){
		ShieldModel sm = new ShieldModel ();
		int expected = 25;

		int result = sm.RepairableThreshold;

		Assert.AreEqual (expected, result);
	}

	[Test]
	public void TestWhenCreatedRepairableTrue(){
		ShieldModel sm = new ShieldModel ();

		bool result = sm.IsRepairable();

		Assert.True (result);
	}

	[Test]
	public void TestAfterDamage1Strength99RepairableTrue(){
		ShieldModel sm = new ShieldModel ();
		int expected = 99;
		sm.TakeDamage (1);

		int result = sm.GetStrength();
		bool repairable = sm.IsRepairable ();

		Assert.AreEqual (expected, result);
		Assert.True (repairable);
	}

	[Test]
	public void TestAfterDamage10Strength90RepairableTrue(){
		ShieldModel sm = new ShieldModel ();
		int expected = 90;
		sm.TakeDamage (10);

		int result = sm.GetStrength();
		bool repairable = sm.IsRepairable ();

		Assert.AreEqual (expected, result);
		Assert.True (repairable);
	}

	[Test]
	public void TestAfter8Damage10Strength20RepairableFalse(){
		ShieldModel sm = new ShieldModel ();
		int expected = 20;
		for (int i = 0; i < 8; i++) {
			sm.TakeDamage (10);
		}
		int result = sm.GetStrength();
		bool repairable = sm.IsRepairable ();

		Assert.AreEqual (expected, result);
		Assert.False (repairable);
	}

	[Test]
	public void TestAfterDamage90Strength10RepairableFalse(){
		ShieldModel sm = new ShieldModel ();
		int expected = 10;
		sm.TakeDamage (90);

		int result = sm.GetStrength();
		bool repairable = sm.IsRepairable ();

		Assert.AreEqual (expected, result);
		Assert.False (repairable);
	}
	[Test]
	public void TestAfterDamage11And1TickStrength99(){
		ShieldModel sm = new ShieldModel ();
		int expected = 99;
		sm.TakeDamage (11);
		sm.Tick ();
		int result = sm.GetStrength();

		Assert.AreEqual (expected, result);
	}
}
