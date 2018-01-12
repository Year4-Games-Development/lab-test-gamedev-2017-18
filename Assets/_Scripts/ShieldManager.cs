using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldManager : MonoBehaviour {

	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	private void Start(){
		//model
		ShieldModel model = new ShieldModel();

		//view
		ShieldView view = new ShieldView();

		//controller
		ShieldController controller = new ShieldController();

		view.SetUITexts (model.GetStrength(), model.IsRepairable() );

	}

	public void ApplyDamageOne(){
		model.TakeDamage (1);
	}

	public void ApplyDamageTen(){
		model.TakeDamage (10);
	}

	public void ApplyTick(){
		model.Tick();

	}

}
