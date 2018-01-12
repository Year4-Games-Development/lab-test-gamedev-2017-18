public class ShieldController 
{
	private ShieldModel model;
	public ShieldModel Model { get { return model; } set { model = value; } }

	private ShieldView view;
	public ShieldView View { get { return view; } set { view = value; } }

	public void HandleDamage(int amount)
	{
		model.TakeDamage (amount);
		view.Refresh ();
	}

	public void HandleTick()
	{
		model.Tick ();
		view.Refresh ();
	}
}
