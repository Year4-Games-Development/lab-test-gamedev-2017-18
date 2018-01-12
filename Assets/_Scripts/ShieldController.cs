using UnityEngine;
using UnityEngine.UI;

public class ShieldController {

	private ShieldModel model;
	private ShieldView view;

	private Button Damage1;
	private Button Damage10;
	private Button Tick;

	public int one = 1;
	public int ten  = 10;

	private void SetModel(ShieldModel model){
		this.model = model;
	}

	private void SetView(ShieldView view){
		this.view = view;
	}

	private void SetButtons(Button Damage1, Button Damage10, Button Tick){
		this.Damage1 = Damage1;
		this.Damage10 = Damage10;
		this.Tick = Tick;
	}

	public void EVENT_Damage1(){
		model.TakeDamage (one);
		view.Refresh ();
	}

	public void EVENT_Damage10(){
		model.TakeDamage (ten);
		view.Refresh ();
	}


}
