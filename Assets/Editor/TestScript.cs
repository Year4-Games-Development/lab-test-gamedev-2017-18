using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class TestScript {



	[Test]
	public void TestStrength() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		Assert.AreEqual(100, shieldModel.GetStrength());
	}

	[Test]
	public void TestRepairQuantity() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		Assert.AreEqual(10, shieldModel.RepairQuantity);
	}

	[Test]
	public void TestRepairTreshold() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		Assert.AreEqual(25, shieldModel.RepairableThreshold);
	}

	[Test]
	public void TestIsRepairAble() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		Assert.IsTrue(shieldModel.IsRepairable());
	}

	[Test]
	public void TestDamage1Strength99() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		shieldModel.TakeDamage(1);
		Assert.IsTrue (shieldModel.IsRepairable());
		Assert.AreEqual(99, shieldModel.GetStrength());
	}

	[Test]
	public void TestDamage10Strength90() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		shieldModel.TakeDamage(10);
		Assert.IsTrue (shieldModel.IsRepairable());
		Assert.AreEqual(90, shieldModel.GetStrength());
	}

	[Test]
	public void TestDamage80Strength20() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		for (int i = 0; i < 8; i++) {
			shieldModel.TakeDamage (10);
		}
		Assert.IsFalse (shieldModel.IsRepairable());
		Assert.AreEqual(20, shieldModel.GetStrength());
	}

	[Test]
	public void TestDamage90Strength10() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		shieldModel.TakeDamage(90);
		Assert.IsFalse (shieldModel.IsRepairable());
		Assert.AreEqual(10, shieldModel.GetStrength());
	}

	[Test]
	public void TestDamage11Tick1Strength99() {
		// Use the Assert class to test conditions.
		ShieldModel shieldModel = new ShieldModel();
		shieldModel.TakeDamage(11);
		shieldModel.Tick ();
		Assert.AreEqual(99, shieldModel.GetStrength());
	}
}
