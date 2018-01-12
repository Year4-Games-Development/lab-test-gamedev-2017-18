using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour {

	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	//text
	public Text strengthValue;
	public Text repairableValue;




	// Use this for initialization
	void Start () {

		//Model
		model = new ShieldModel();

		//View
		view = new ShieldView();
		view.setModel (model);
		view.SetUITexts (strengthValue, repairableValue);
		view.Refresh();

		//controller
		controller = new ShieldController();
		controller.SetModel (model);
		controller.SetView (view);
	}

	//Button clicks
	//One Damage
	public void BUTTON_Damage1()
	{
		controller.EVENT_TakeDamage1;
	}

	//Ten dmaage
	public void BUTTON_Damage10()
	{
		controller.EVENT_TakeDamage10;
	}

	//Tick
	public void BUTTON_Tick()
	{
		controller.EVENT_Tick;
	}
}
