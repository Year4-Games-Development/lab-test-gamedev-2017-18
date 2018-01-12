using UnityEngine;
using UnityEngine.UI;

public class ShieldView{

	private ShieldModel model;
	private Text textStrenght;
	private Text textRepairable;
	private RawImage imageShield;
	private Texture[] images;

	public void SetModel(ShieldModel model){
		this.model = model;
	}

	public void SetImages(Texture[] images){
		this.images = images;
	}

	public void SetUIItems(Text textStrenght, Text textRepairable, RawImage imageShield){
		this.textStrenght = textStrenght;
		this.textRepairable = textRepairable;
		this.imageShield = imageShield;
	}

	public void Refresh(){
		this.textStrenght.text = model.GetStrength ().ToString ();
		this.textRepairable.text = model.IsRepairable ().ToString ();

		int strength = model.GetStrength ();
		if (strength > 90) {
			imageShield.texture = images [10];
		} else if (strength > 80) {
			imageShield.texture = images [9];
		} else if (strength > 70) {
			imageShield.texture = images [8];
		} else if (strength > 60) {
			imageShield.texture = images [7];
		} else if (strength > 50) {
			imageShield.texture = images [6];
		} else if (strength > 40) {
			imageShield.texture = images [5];
		} else if (strength > 30) {
			imageShield.texture = images [4];
		} else if (strength > 20) {
			imageShield.texture = images [3];
		} else if (strength > 10) {
			imageShield.texture = images [2];
		} else if (strength > 0) {
			imageShield.texture = images [1];
		} else {
			imageShield.texture = images [0];
		}
	}
}
