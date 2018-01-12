using UnityEngine;
using UnityEngine.UI;

public class ShieldView {

	private ShieldModel model;
	private Text StrengthText;
	private Text TrueOrFalse;

	public void SetModel(ShieldModel model){
		this.model = model;
	}


	public void SetUITexts(Text StrengthText, Text TrueOrFalse){
		this.StrengthText = StrengthText;
		this.TrueOrFalse = TrueOrFalse;
	}

	public void Refresh(){
		this.StrengthText.text = model.GetStrength ().ToString ();
		this.TrueOrFalse.text = model.IsRepairable ().ToString ();
	}

}
