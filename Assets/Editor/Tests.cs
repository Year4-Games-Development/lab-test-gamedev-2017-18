using NUnit.Framework;

public class Tests {

	[Test]
	public void CheckingStrengthIsHundred()
	{
		ShieldModel sh = new ShieldModel ();

		Assert.AreEqual (sh.GetStrength (), 100);
	}

	[Test]
	public void CheckingRepairQuantity()
	{
		ShieldModel sh = new ShieldModel ();

		Assert.AreEqual (sh.RepairQuantity, 10);
	}

	[Test]
	public void CheckingRepairTreshold()
	{
		ShieldModel sh = new ShieldModel ();

		Assert.AreEqual (sh.RepairableThreshold, 25);
	}


	[Test]
	public void CheckingIsRepairable()
	{
		ShieldModel sh = new ShieldModel ();

		Assert.AreEqual (sh.IsRepairable(), true);
	}

	/// 
	/// Post - Action tests
	/// 


	// 1 Damage, isRepairable returns TRUE 
	[Test]
	public void CheckingAfter_1_DamageIsRepairableTrue()
	{
		ShieldModel sh = new ShieldModel ();
		sh.TakeDamage (1);

		Assert.AreEqual (sh.IsRepairable(), true);
	}

	// Strength is 99
	[Test]
	public void CheckingAfter_1_DamageStrengthIs99()
	{
		ShieldModel sh = new ShieldModel ();
		sh.TakeDamage (1);

		Assert.AreEqual (sh.GetStrength(), 99);
	}

	/////////////////////////////////////////////////////////


	// 10 Damage, isRepairable returns TRUE 
	[Test]
	public void CheckingAfter_10_DamageIsRepairableTrue()
	{
		ShieldModel sh = new ShieldModel ();
		sh.TakeDamage (10);

		Assert.AreEqual (sh.IsRepairable(), true);
	}

	// Strength is 90
	[Test]
	public void CheckingAfter_10_DamageStrengthIs90()
	{
		ShieldModel sh = new ShieldModel ();
		sh.TakeDamage (10);

		Assert.AreEqual (sh.GetStrength(), 90);
	}


	/////////////////////////////////////////////////////////

	// 80 Damage, isRepairable returns FLASE
	[Test]
	public void CheckingAfter_80_DamageIsRepairable_False()
	{
		ShieldModel sh = new ShieldModel ();

		for(int i = 0; i< 8 ; i++){
			sh.TakeDamage (10);
		}

		Assert.AreEqual (sh.IsRepairable(), false);
	}

	// Strength is 20
	[Test]
	public void CheckingAfter_80_DamageStrengthIs20()
	{
		ShieldModel sh = new ShieldModel ();
		for(int i = 0; i< 8 ; i++){
			sh.TakeDamage (10);
		}


		Assert.AreEqual (sh.GetStrength(), 20);
	}

	/////////////////////////////////////////////////////////



	// 90 Damage, isRepairable returns FLASE
	[Test]
	public void CheckingAfter_90_DamageIsRepairable_False()
	{
		ShieldModel sh = new ShieldModel ();

		sh.TakeDamage (90);

		Assert.AreEqual (sh.IsRepairable(), false);
	}

	// Strength is 10
	[Test]
	public void CheckingAfter_90_DamageStrengthIs10()
	{
		ShieldModel sh = new ShieldModel ();

		sh.TakeDamage (90);

		Assert.AreEqual (sh.GetStrength(), 10);
	}

	/////////////////////////////////////////////////////////




	// 11 Damage, followed by Tick()
	[Test]
	public void CheckingAfter_11_DamageAfterTickStrengthIs10()
	{
		ShieldModel sh = new ShieldModel ();

		sh.TakeDamage (11);
		sh.Tick ();

		Assert.AreEqual (sh.GetStrength(), 99);
	}

	/////////////////////////////////////////////////////////
}
