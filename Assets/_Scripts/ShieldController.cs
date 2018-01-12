using UnityEngine.UI;

public class ShieldController {

	private ShieldModel model;
	private ShieldView view;

	//input field

	public void SetModel(ShieldModel model)
	{
		this.model = model;
	}

	public void SetView(ShieldView view)
	{
		this.view = view;
	}  

	//setInputFie;dDelivery

	//private int GetQuantityFromInputField

	//---------Events--------
	public void EVENT_TakeDamage1()
	{
		int damage = 1;
		model.TakeDamage (damage);
		view.Refresh ();
	}

	public void EVENT_TakeDamage10()
	{
		int damage = 10;
		model.TakeDamage (damage);
		view.Refresh ();
	}

	public void EVENT_Tick()
	{
		if (model.IsRepairable = true & model.RepairableThreshold > 25) 
		{
			//model.RepairQuantity = +10;
			view.Refresh ();
		}
	}

}
