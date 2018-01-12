using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour {

	private ShieldModel model;
	private ShieldView view;

	public void CheckStrengthValue(){

		int strenght = model.GetStrength ();

		if (strenght == 0 && strenght < 10) {
		
			view.SetUITexts (model.GetStrength(), model.IsRepairable() );


			//view.SetImageSprite (0);
		}
		else if(strenght == 10 && strenght < 20){
			
		}
		else if(strenght == 20 && strenght < 30){

		}
		else if(strenght == 30 && strenght < 40){

		}
		else if(strenght == 40 && strenght < 50){

		}
		else if(strenght == 50 && strenght < 60){

		}
		else if(strenght == 60 && strenght < 70){

		}
		else if(strenght == 70 && strenght < 80){

		}
		else if(strenght == 80 && strenght < 90){

		}
		else if(strenght == 90 && strenght <= 100){

		}
	}

}
