using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ShieldView {

	//public Text text;

	public Texture [] images;
	public Text Strength;
	public Text Repairable;
	public RawImage circleImage;
	private ShieldModel sm = new ShieldModel();

	void Update(){

	}

	public void TakingDamage(){

		if (sm.GetStrength () > 90) {
			//circleImage = images [9];
			images[9] = circleImage.mainTexture;
		}
		else if (sm.GetStrength () > 80) {
			//circleImage = images [8];
		}
		else if (sm.GetStrength () > 70) {
			//circleImage = images [7];
		}
		else if (sm.GetStrength () > 60) {
			//circleImage = images [6];
		}
		else if (sm.GetStrength () > 50) {
			//circleImage = images [5];
		}
		else if (sm.GetStrength () > 40) {
			//circleImage = images [4];
		}
		else if (sm.GetStrength () > 30) {
			//circleImage = images [3];
		}
		else if (sm.GetStrength () > 20) {
//			circleImage = images [2];
		}
		else if (sm.GetStrength () > 10) {
			//circleImage = images [1];
		}
		else if (sm.GetStrength () > 0) {
			//circleImage = images [0];
		}

	}

	public void UpdatingViewForStrength(int strength, bool repairable){

		Strength.text = strength + "%";
		Repairable.text = repairable + " ";

	}

}

