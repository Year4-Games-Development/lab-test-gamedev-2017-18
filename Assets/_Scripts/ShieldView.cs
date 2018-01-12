using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView : MonoBehaviour {

	private ShieldController shieldCont;

	public Button button1Damage;
	public Button button10Damage;
	public Button buttonTick;
	public Text repText;
	public Text strText;

	public void Awake(){
	
		shieldCont = GetComponent<ShieldController> ();
	}

	public void Start(){
		button1Damage.onClick.AddListener(shieldCont.Button1Damage);
		button10Damage.onClick.AddListener (shieldCont.Button10Damage);
		buttonTick.onClick.AddListener (shieldCont.ButtonTick);
	}


	public void UpdateIsRepairable(bool isRep){
		if(!isRep){
			repText.text = "False";
		}
		else{
			repText.text = "True";
		}
	}

	public void UpdateStrText(int strengthT){
		strText.text = "" +strengthT + "%";
	}

	public void UpdateImage(){
	
	}
}
