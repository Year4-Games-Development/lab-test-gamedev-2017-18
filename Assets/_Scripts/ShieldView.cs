using UnityEngine.UI;

public class ShieldView {

	private ShieldModel model;
	private Text strengthValue;
	private Text repairableValue;

	public void setModel(ShieldModel model)
	{
		this.model = model;
	}
		
	public void SetUITexts(Text strengthValue, Text repairableValue)
	{
		this.strengthValue = strengthValue;
		this.repairableValue = repairableValue;
	}

	//Refresh text on screen
	public void Refresh()
	{
		this.strengthValue.text = model.GetStrength ().ToString ();
		this.repairableValue.text = model.IsRepairable ().ToString ();
	}
}
