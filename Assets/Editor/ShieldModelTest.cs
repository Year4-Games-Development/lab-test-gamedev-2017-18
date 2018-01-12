using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ShieldModelTest {

	[Test]
	public void TestWhenStrengthIs0() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 100;

		//act
		int result = sm.GetStrength();

		//assert
		Assert.AreEqual(result, expectedResult);
		
	}

	[Test]
	public void TestRepairQuantityIs10() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 10;

		//act
		int result = sm.RepairQuantity;

		//assert
		Assert.AreEqual(result, expectedResult);

	}

	[Test]
	public void TestRepairableThresholdIs25() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 25;

		//act
		int result = sm.RepairableThreshold;

		//assert
		Assert.AreEqual(result, expectedResult);

	}

	[Test]
	public void TestIsRepairableReturnsTrue() {
		//arrange 
		ShieldModel sm = new ShieldModel ();


		//act
		bool result = sm.IsRepairable();

		//assert
		Assert.True(result);

	}


	[Test]
	public void TestAfter1DamageOf1RepairableShouldReturnTrueAndStrength99() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int damageQty = 1;
		int expectedDamage = 100;

		//act
		bool damageSuccess = sm.IsRepairable();
		int result = sm.GetStrength();

		//assert
		Assert.True(damageSuccess);
		Assert.AreEqual (result, expectedDamage);

	}

	[Test]
	public void TestAfter1DamageOf10RepairableShouldReturnTrueAndStrength90() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int damageQty = 10;
		int expectedDamage = 100;

		//act
		bool damageSuccess = sm.IsRepairable();
		int result = sm.GetStrength();

		//assert
		Assert.True(damageSuccess);
		Assert.AreEqual (result, expectedDamage);

	}

	[Test]
	public void TestAfter8DamageOf10RepairableshouldReturnFalseAndStrength20() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int damageQty = 10*8;
		int expectedDamage = 100;

		//act
		bool damageSuccess =  sm.IsRepairable();
		int result = sm.GetStrength();

		//assert
		Assert.True(damageSuccess);
		Assert.AreEqual (result, expectedDamage);

	}

	[Test]
	public void TestAfter1DamageOf90RepairableshouldReturnFalseAndStrength10() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int damageQty = 90;
		int expectedDamage = 100;

		//act
		bool damageSuccess =  sm.IsRepairable();
		int result = sm.GetStrength();

		//assert
		Assert.True(damageSuccess);
		Assert.AreEqual (result, expectedDamage);

	}

	[Test]
	public void TestAfter1DamageOf11FollowedBy1TickAndStrength90() {
		//arrange 
		ShieldModel sm = new ShieldModel ();
		int damageQty = 11;
		int tickQty = 1;
		int expectedDamage = 100;

		//act
		bool damageSuccess =  sm.IsRepairable();
		sm.Tick ();
		int result = sm.GetStrength();

		//assert
		Assert.True(damageSuccess);
		Assert.AreEqual (result, expectedDamage);

	}
}
