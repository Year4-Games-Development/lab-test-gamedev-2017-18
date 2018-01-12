public class ShieldController {

	private ShieldModel shieldModel;
	private ShieldView shieldView;

	public void SetShieldModel(ShieldModel shieldModel)
	{
		this.shieldModel = shieldModel;
	}

	public void SetShieldView(ShieldView shieldView)
	{
		this.shieldView = shieldView;
	}

	//---EVENTS---
	public void EVENT_Damage(int damage) 
	{
		shieldModel.TakeDamage (damage);
		shieldView.Refresh ();
	}

	public void EVENT_Tick ()
	{
		shieldModel.Tick ();
		shieldView.Refresh ();
	}
}
