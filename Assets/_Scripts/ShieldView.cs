using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ShieldView 
{

	private ShieldModel shieldModel;
	private Text strengthText;
	private Text repairableText;

	private RawImage shieldStrengthImage;
	private Texture[] shieldStrengthTextures;

	public void SetModel (ShieldModel shieldModel) 
	{
		this.shieldModel = shieldModel;
	}

	public void SetUITexts (Text strengthText, Text repairableText)
	{
		this.strengthText = strengthText;
		this.repairableText = repairableText;
	}

	public void SetImages (RawImage shieldStrengthImage, Texture[] shieldStrengthTextures)
	{
		this.shieldStrengthImage = shieldStrengthImage;
		this.shieldStrengthTextures = shieldStrengthTextures;
	}

	public void Refresh ()
	{
		int shieldStrength = shieldModel.GetStrength ();

		this.strengthText.text = shieldStrength.ToString ();
		this.repairableText.text = shieldStrength.ToString ();

		if (shieldStrength > 90) {
			shieldStrengthImage.texture = shieldStrengthTextures [10];
		} else if (shieldStrength > 80) {
			shieldStrengthImage.texture = shieldStrengthTextures [9];
		} else if (shieldStrength > 70) {
			shieldStrengthImage.texture = shieldStrengthTextures [8];
		} else if (shieldStrength > 60) {
			shieldStrengthImage.texture = shieldStrengthTextures [7];
		} else if (shieldStrength > 50) {
			shieldStrengthImage.texture = shieldStrengthTextures [6];
		} else if (shieldStrength > 40) {
			shieldStrengthImage.texture = shieldStrengthTextures [5];
		} else if (shieldStrength >30) {
			shieldStrengthImage.texture = shieldStrengthTextures [4];
		} else if (shieldStrength > 20) {
			shieldStrengthImage.texture = shieldStrengthTextures [3];
		} else if (shieldStrength > 10) {
			shieldStrengthImage.texture = shieldStrengthTextures [2];
		}  else if (shieldStrength > 0) {
			shieldStrengthImage.texture = shieldStrengthTextures [1];
		} else if (shieldStrength == 0) {
			shieldStrengthImage.texture = shieldStrengthTextures [0];
		}
	}
}
