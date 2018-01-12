using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour {

	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	public Text textRepair;
	public Text textStrength;
	public RawImage imageShield;
	public Texture[] images;

	// Use this for initialization
	void Start () {
		model = new ShieldModel ();

		view = new ShieldView ();
		view.SetModel (model);
		view.SetUIItems (textStrength, textRepair, imageShield);
		view.SetImages (images);
		view.Refresh ();


		controller = new ShieldController ();
		controller.SetModel (model);
		controller.SetView (view);
	}

	public void BUTTON_Damage1(){
		controller.EVENT_Damage (1);
	}

	public void BUTTON_Damage10(){
		controller.EVENT_Damage (10);
	}

	public void BUTTON_Tick(){
		controller.EVENT_Tick ();
	}
}
