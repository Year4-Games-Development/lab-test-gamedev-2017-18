using UnityEngine.UI;

public class ShieldController{

	private ShieldModel model;
	private ShieldView view;

	public void SetModel(ShieldModel model){
		this.model = model;
	}

	public void SetView(ShieldView view){
		this.view = view;
	}

	//-------------Events---------------
	public void EVENT_Damage(int damage){
		model.TakeDamage (damage);
		view.Refresh ();
	}

	public void EVENT_Tick(){
		model.Tick ();
		view.Refresh ();
	}

}
