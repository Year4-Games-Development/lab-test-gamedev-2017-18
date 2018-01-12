using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class View{

	public Text repairableValue;
	public Text strengthValue;
	public RawImage image;

	public Texture[] texures;

	public void UpdateRepairableValue(bool isRepairable){

		repairableValue.text = isRepairable.ToString ();

	}

	public void UpdateStrengthValue(int value){

		strengthValue.text = value + "%";

	}

	public void UpdateImageBasedOnStrength(int value){

		image.texture = texures [value];

	}

}
