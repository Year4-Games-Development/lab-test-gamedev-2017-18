using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView : MonoBehaviour {
	public RawImage shieldImgDisplay;
	public Text shieldTextDisplay;
	public Text isRepairableText;
	public Texture[] imagesArray;

	public void ShieldViewUpdate(int strenght, bool isRepairable){
		
		shieldTextDisplay.text = strenght.ToString() + "%";
		isRepairableText.text = isRepairable.ToString ();
		ChangeImage (strenght);

	}

	public void ChangeImage(int strenght){
		if (strenght > 90) {
			shieldImgDisplay.texture = imagesArray [0];
		} else if (strenght > 80) {
			shieldImgDisplay.texture = imagesArray [1];
		} else if (strenght > 70) {
			shieldImgDisplay.texture = imagesArray [2];	
		} else if (strenght > 60) {
			shieldImgDisplay.texture = imagesArray [3];
		} else if (strenght > 50) {
			shieldImgDisplay.texture = imagesArray [4];
		} else if (strenght > 40) {
			shieldImgDisplay.texture = imagesArray [5];	
		} else if (strenght > 30) {
			shieldImgDisplay.texture = imagesArray [6];
		} else if (strenght > 20) {
			shieldImgDisplay.texture = imagesArray [7];
		} else if (strenght > 10) {
			shieldImgDisplay.texture = imagesArray [8];	
		} else if (strenght > 1) {
			shieldImgDisplay.texture = imagesArray [9];
		} else {
			shieldImgDisplay.texture = imagesArray [10];
		}
	}
}
