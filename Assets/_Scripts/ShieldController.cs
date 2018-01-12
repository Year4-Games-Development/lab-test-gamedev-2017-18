using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldController : MonoBehaviour {

	private ShieldModel shieldModel = new ShieldModel ();
	private ShieldView shieldView;
	public RawImage[] imageArr;

	void Start(){
		shieldView = GetComponent<ShieldView> ();
	}

	public void Button1Damage(){
		shieldModel.TakeDamage (1);
		shieldView.UpdateStrText (shieldModel.GetStrength());
		shieldView.UpdateIsRepairable (shieldModel.IsRepairable());
		Debug.Log (shieldModel.GetStrength());
	}

	public void Button10Damage(){
		shieldModel.TakeDamage (10);
		shieldView.UpdateStrText (shieldModel.GetStrength());
		shieldView.UpdateIsRepairable (shieldModel.IsRepairable());
		Debug.Log (shieldModel.GetStrength());
	}

	public void ButtonTick(){
		if (shieldModel.GetStrength() > shieldModel.RepairableThreshold) {
			shieldModel.Tick ();
			shieldView.UpdateStrText (shieldModel.GetStrength());
			Debug.Log ("Ticked");
		}
	}
	public void InitializeImages(){
		
	}

}
