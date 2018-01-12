using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour {

	private ShieldModel shieldModel;
	private ShieldView shieldView;
	private ShieldController shieldController;

	public Text strengthText;
	public Text repairableText;

	public RawImage shieldStrengthImage;
	public Texture[] shieldStengthImages;

	void Start ()
	{
		// model
		shieldModel = new ShieldModel ();

		// view
		shieldView = new ShieldView ();
		shieldView.SetModel (shieldModel);
		shieldView.SetUITexts (strengthText, repairableText);
		shieldView.SetImages (shieldStrengthImage, shieldStengthImages);
		shieldView.Refresh ();

		// controller
		shieldController = new ShieldController ();
		shieldController.SetShieldModel (shieldModel);
		shieldController.SetShieldView (shieldView);
	}

	public void BUTTON_OneDamageClick ()
	{
		shieldController.EVENT_Damage (1);
	}

	public void BUTTON_TenDamageClick ()
	{
		shieldController.EVENT_Damage (10);
	}

	public void BUTTON_TickClick ()
	{
		shieldController.EVENT_Tick ();
	}
}
