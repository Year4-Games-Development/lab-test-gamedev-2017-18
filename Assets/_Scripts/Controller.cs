using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	[SerializeField]
	private View view;
	private ShieldModel model;

	void Awake(){

		model = new ShieldModel ();

	}

	void Start(){

		UpdateView ();

	}

	public void TakeDamage(int value){

		model.TakeDamage (value);
		UpdateView ();

	}

	public void Tick(){

		model.Tick ();
		UpdateView ();

	}

	public void UpdateView(){

		view.UpdateRepairableValue (model.IsRepairable());
		view.UpdateStrengthValue (model.GetStrength ());

		view.UpdateImageBasedOnStrength(CalculateImageIndexUsingStrength (model.GetStrength()));

	}

	public int CalculateImageIndexUsingStrength (int value){

		if (value > 90)
			return 10;
		else if (value > 80)
			return 9;
		else if (value > 70)
			return 8;
		else if (value > 60)
			return 7;
		else if (value > 50)
			return 6;
		else if (value > 40)
			return 5;
		else if (value > 30)
			return 4;
		else if (value > 20)
			return 3;
		else if (value > 10)
			return 2;
		else if (value > 0)
			return 1;
		else
			return 0;

	}

}
