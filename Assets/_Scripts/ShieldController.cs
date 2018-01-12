using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour {
	public ShieldView shieldView;
	private ShieldModel shieldModel;
	// Use this for initialization
	void Start () {
		shieldModel = new ShieldModel ();
		shieldView.ShieldViewUpdate (shieldModel.GetStrength(), shieldModel.IsRepairable());
	}

	public void DamageOne(){
		shieldModel.TakeDamage (1);
		shieldView.ShieldViewUpdate (shieldModel.GetStrength(), shieldModel.IsRepairable());
	}
	
	public void DamageTen(){
		shieldModel.TakeDamage (10);
		shieldView.ShieldViewUpdate (shieldModel.GetStrength(), shieldModel.IsRepairable());
	}

	public void ShieldTick(){
		shieldModel.Tick();
		shieldView.ShieldViewUpdate (shieldModel.GetStrength(), shieldModel.IsRepairable());
	}
}
