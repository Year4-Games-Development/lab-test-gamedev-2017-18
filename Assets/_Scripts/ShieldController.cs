using UnityEngine;
using UnityEngine.UI;

public class ShieldController
{
	private ShieldModel model;
	private ShieldView view;

	private Button DamageOne;
	private Button DamageTen;
	private Button ButtonTick;

	public void SetModel(ShieldModel model)
	{
		this.model = model;
	}

	public void SetView(ShieldView view)
	{
		this.view = view;
	}

	public void SetButtonOne(Button DamageOne)
	{
		this.DamageOne = DamageOne;
	}

	public void SetButtonTen(Button DamageTen)
	{
		this.DamageTen = DamageTen;
	}

	public void SetButtonTick(Button ButtonTick)
	{
		this.ButtonTick = ButtonTick;
	}

	//Event Damage One
	public void EVENT_Damage_One()
	{
		int damage = 1;
		model.TakeDamage (damage);
		view.Refresh();
	}

	//Event Damage Ten
	public void EVENT_Damage_Ten()
	{
		int damage = 10;
		model.TakeDamage (damage);
		view.Refresh();
	}

	//Event Button Tick
	public void EVENT_Button_Tick()
	{
		if (model.IsRepairable())
			model.Tick ();
		view.Refresh ();
	}
}
