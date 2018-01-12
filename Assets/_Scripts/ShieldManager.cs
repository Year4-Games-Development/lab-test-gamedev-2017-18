using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour 
{
	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;
	public Text Damage1;
	public Text Damage10;

	void Start()
	{
		// Model
		model = new ShieldModel();

		// View
		view = new ShieldView();
		view.SetModel(model);
		view.SetUITexts(Damage1, Damage10);
		view.Refresh();

		//Controller
		controller = new ShieldController();
		controller.SetModel(model);
		controller.SetView(view);
		controller.SetDamage1Text(Damage1);
	}

	public void BUTTON_Damage1OnClick()
	{
		controller.EVENT_Damage();
	}

	public void BUTTON_Damage10OnClick()
	{
		controller.EVENT_Damage();
	}
}