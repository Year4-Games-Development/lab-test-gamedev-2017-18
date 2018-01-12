using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class LabTestUitTests {
	//Part 2
	ShieldModel shieldModel = new ShieldModel ();

	[Test]
	public void TestIfStrenghtIs100() {
		Assert.AreEqual (shieldModel.GetStrength (), 100);
	}

	[Test]
	public void TestIfRepairQuantityIs10() {
		Assert.AreEqual (shieldModel.RepairQuantity, 10);
	}

	[Test]
	public void TestIfRepairTresholdIs25() {
		Assert.AreEqual (shieldModel.RepairableThreshold, 25);
	}

	[Test]
	public void TestIfRepairableIsTrue() {
		Assert.AreEqual (shieldModel.IsRepairable (), true);
	}
	//Part 3
	[Test]
	public void TestIfAfter1dmgOf1IsRepairableIsTrueAndStrenghtIs99() {
		ShieldModel shieldModel2 = new ShieldModel ();
		shieldModel2.TakeDamage (1);
		Assert.AreEqual (shieldModel2.IsRepairable(), true);
		Assert.AreEqual (shieldModel2.GetStrength (), 99);
	}

	[Test]
	public void TestIfAfter1dmgOf10IsRepairableIsTrueAndStrenghtIs90() {
		ShieldModel shieldModel3 = new ShieldModel ();
		shieldModel3.TakeDamage (10);
		Assert.AreEqual (shieldModel3.IsRepairable(), true);
		Assert.AreEqual (shieldModel3.GetStrength (), 90);
	}

	[Test]
	public void TestIfAfter8dmgOf10IsRepairableIsFalseAndStrenghtIs20() {
		ShieldModel shieldModel4 = new ShieldModel ();
		for (int i = 0; i < 8; i++) {
			shieldModel4.TakeDamage (10);
		}

		Assert.AreEqual (shieldModel4.IsRepairable(), false);
		Assert.AreEqual (shieldModel4.GetStrength (), 20);
	}

	[Test]
	public void TestIfAfter1dmgOf90IsRepairableIsFalseAndStrenghtIs10() {
		ShieldModel shieldModel5 = new ShieldModel ();
		shieldModel5.TakeDamage (90);
		Assert.AreEqual (shieldModel5.IsRepairable(), false);
		Assert.AreEqual (shieldModel5.GetStrength (), 10);
	}

	[Test]
	public void TestIfAfter1dmgOf11and1tickStrenghtIs99() {
		ShieldModel shieldModel6 = new ShieldModel ();
		shieldModel6.TakeDamage (11);
		shieldModel6.Tick ();
		Assert.AreEqual (shieldModel6.GetStrength (), 99);
	}
}
