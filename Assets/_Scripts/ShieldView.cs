using UnityEngine;
using UnityEngine.UI;


public class ShieldView : MonoBehaviour {

	private ShieldModel model;

	[SerializeField]
	private Text strengthValueText;

	[SerializeField]
	private Text repairableValueText;

	[SerializeField]
	private Image strenghtImage;

	[SerializeField]
	private Sprite[] strenghtColor;

	public Sprite[] StrenghtColor {
		get {
			return strenghtColor;
		}
	}
		
	public void SetUITexts(int strenghtValue, bool repairableValue){
	
		strengthValueText.text = strenghtValue.ToString();
		repairableValueText.text = repairableValue.ToString();

	}

	public void SetImageSprite(int temp){
	
		strenghtImage.GetComponent<Image> ().sprite = strenghtColor [0];
	}

	public void Refresh(){
	
		strengthValueText.text = model.GetStrength().ToString();
		repairableValueText.text = model.IsRepairable().ToString();
	}

}
