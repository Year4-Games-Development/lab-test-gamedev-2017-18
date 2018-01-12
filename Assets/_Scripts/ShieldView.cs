using UnityEngine.UI;
using System;

public class ShieldView
{
	private ShieldModel model;
	private Text textStrength;
	private Text textIsRepairable;

	public void SetModel(ShieldModel model)
	{
		this.model = model;
	}
	
	public void SetUIText(Text textStrength, Text textIsRepairable)
	{
		this.textStrength = textStrength;
		this.textIsRepairable = textIsRepairable;
	}

	public void Refresh()
	{
		this.textStrength.text = model.GetStrength().ToString();
		this.textIsRepairable.text = model.IsRepairable().ToString();

		//if(model.GetStrength > 90)
	}
}
