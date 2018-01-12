using UnityEngine;
using UnityEngine.UI;
using System;

public class ShieldManager : MonoBehaviour
{
	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	public Text textStrength;
	public Text textIsRepairable;

	private Button DamageOne;
	private Button DamageTen;
	private Button ButtonTick;

	void Start()
	{
		// model
		model = new ShieldModel();

		//view
		view = new ShieldView();
		view.SetModel (model);
		view.SetUIText (textStrength, textIsRepairable);
		view.Refresh ();

		//controller
		controller = new ShieldController();
		controller.SetModel (model);
		controller.SetView (view);
		controller.SetButtonOne (DamageOne);
		controller.SetButtonTen (DamageTen);
		controller.SetButtonTick (ButtonTick);
	}

	public void BUTTON_Damage_One()
	{
		controller.EVENT_Damage_One ();
	}

	public void BUTTON_Damage_Ten()
	{
		controller.EVENT_Damage_Ten ();
	}

	public void BUTTON_Tick()
	{
		controller.EVENT_Button_Tick ();
	}
}
