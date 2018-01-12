using NUnit.Framework;

public class ModelTests{


	[Test]
	public void ConsructorTestForStrength(){

		ShieldModel model = new ShieldModel ();

		Assert.AreEqual (model.GetStrength(), 100);

	}

	[Test]
	public void ConsructorTestForRepairQuantity(){

		ShieldModel model = new ShieldModel ();

		Assert.AreEqual (model.RepairQuantity, 10);

	}

	[Test]
	public void ConsructorTestForRepairThreshold(){

		ShieldModel model = new ShieldModel ();

		Assert.AreEqual (model.RepairableThreshold, 25);

	}

	[Test]
	public void ConsructorTestForIsRepairable(){

		ShieldModel model = new ShieldModel ();

		Assert.AreEqual (model.IsRepairable(), true);

	}

	[Test]
	public void IsRepairableReturnsTrueAfterOneDamage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(1);

		Assert.AreEqual (model.IsRepairable(), true);

	}

	[Test]
	public void IsStrengh99After1Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(1);

		Assert.AreEqual (model.GetStrength(), 99);

	}

	[Test]
	public void IsRepairableReturnsTrueAfter10Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(10);

		Assert.AreEqual (model.IsRepairable(), true);

	}

	[Test]
	public void IsStrengh90After10Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(10);

		Assert.AreEqual (model.GetStrength(), 90);

	}

	[Test]
	public void IsRepairableReturnsFalseAfter_8_10_Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);

		Assert.AreEqual (model.IsRepairable(), false);

	}

	[Test]
	public void IsStrengh20After_8_10_Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);
		model.TakeDamage(10);

		Assert.AreEqual (model.GetStrength(), 20);

	}

	[Test]
	public void IsRepairableReturnsFalseAfterOne90Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(90);


		Assert.AreEqual (model.IsRepairable(), false);

	}

	[Test]
	public void IsStrengh10AfterOne90Damage(){

		ShieldModel model = new ShieldModel ();

		model.TakeDamage(90);

		Assert.AreEqual (model.GetStrength(), 10);

	}

	[Test]
	public void IsStrength99After11DamageAndTick(){


		ShieldModel model = new ShieldModel ();

		model.TakeDamage (11);
		model.Tick ();

		Assert.AreEqual (model.GetStrength (), 99);

	}
}
