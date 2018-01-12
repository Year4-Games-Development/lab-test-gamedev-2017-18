using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView {

	private ShieldModel model;
	private Text textStrengthLabel;
	private Text textStrengthValue;
	private Text textRepairableLabel;
	private Text textRepairableValue;

	public void SetModel(ShieldModel model){
		this.model = model;
	}

	public void SetUITexts(Text textStrengthLabel, Text textStrengthValue, 
		Text textRepairableLabel, Text textRepairableValue){

		this.textStrengthLabel = textStrengthLabel;
		this.textStrengthValue = textStrengthValue;
		this.textRepairableLabel = textRepairableLabel;
		this.textRepairableValue = textRepairableValue;
	}

	public void Refresh(){
		this.textStrengthLabel.text = model.GetStrength ().ToString ();
		this.textStrengthValue.text = model.GetStrength ().ToString ();
		this.textRepairableValue.text = model.IsRepairable().ToString ();
		this.textRepairableLabel.text = model.IsRepairable ().ToString ();
	}

}
