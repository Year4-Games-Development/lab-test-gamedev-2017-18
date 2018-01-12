using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour {

	[SerializeField]
	public ShieldView view;

	private ShieldModel sm = new ShieldModel ();

	public void ButtonAction1(){

		sm.TakeDamage (1);
		//view.TakingDamage ();
		print (sm.GetStrength ());
		view.UpdatingViewForStrength (sm.GetStrength(), sm.IsRepairable());
	}
		
	public void ButtonAction10(){

		sm.TakeDamage (10);
		print (sm.GetStrength ());
		view.UpdatingViewForStrength (sm.GetStrength(), sm.IsRepairable());
	}

	public void ButtonActionTick(){
		if (sm.GetStrength() >= sm.RepairableThreshold) 
		{
			sm.AddStrength (50);
			print (sm.GetStrength ());
					view.UpdatingViewForStrength (sm.GetStrength(), sm.IsRepairable());
		}
	}


}
