using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour {

	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	public Text StrengthText;
	public Text TrueOrFalse;
	public Button Damage1;
	public Button Damage10;
	public Button Tick;

	void Start(){
		//model
		model = new ShieldModel ();

		//view
		view = new ShieldView ();
		view.SetModel (model);
		view.SetUITexts (StrengthText, TrueOrFalse);
		view.Refresh ();

		//controller
		controller = new ShieldController ();
		controller.SetModel (model);
		controller.SetView (view);
		controller.SetButtons (Damage1, Damage10);
	}

	public void Button_Damage1Click(){
		controller.EVENT_Damage1 ();
	}

	public void Button_DamageTenClick(){
		controller.EVENT_Damage10 ();
	}
}
