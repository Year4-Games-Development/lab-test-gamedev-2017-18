using UnityEngine.UI;

public class ShieldView
{
	private ShieldModel model;
	private Text Damage1;
	private Text Damage10;

	public void SetModel(ShieldModel model)
	{
		this.model = model;
	}

	public void SetUITexts(Text Damage1, Text Damage10)
	{
		this.Damage1 = Damage1;
		this.Damage10 = Damage10;
	}

	public void Refresh()
	{
		this.Damage1.text = model.TakeDamage().ToString();
		this.Damage10.text = model.TakeDamage().ToString();
	}
}