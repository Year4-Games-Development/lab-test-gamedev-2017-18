using System;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView 
{
	private ShieldModel model;
	public ShieldModel Model { get { return model; } set { model = value; } }

	private Text shieldStrengthText;
	public Text ShieldStrengthText { get { return shieldStrengthText; } set { shieldStrengthText = value; } }
	private Text repairableText;
	public Text RepairableText { get { return repairableText; } set { repairableText = value; } }
	public RawImage shieldStrengthImage;
	public RawImage ShieldStrengthImage { get { return shieldStrengthImage; } set { shieldStrengthImage = value; } }
	private Texture[] shieldStrengthTextures;
	public Texture[] ShieldStrengthTextures { get { return shieldStrengthTextures; } set { shieldStrengthTextures = value; } }

	public void Refresh()
	{
		int strength = model.GetStrength ();
		shieldStrengthText.text = strength + "%";
		repairableText.text = model.IsRepairable ().ToString ();
		int textureIndex;
		if (strength == 0) {
			textureIndex = 0;
		} else {
			double d = strength / 10;
			textureIndex = (int) Math.Ceiling(d);
		}
		shieldStrengthImage.texture = shieldStrengthTextures [textureIndex];
	}
}
