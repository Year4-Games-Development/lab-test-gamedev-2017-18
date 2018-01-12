using UnityEngine.UI;

public class ShieldController
{
	private ShieldModel model;
	private ShieldView view;
	public Text Damage1;
	public Text Damage10;
	public RawImage StrengthImg0;
	public RawImage StrengthImg10;
	public RawImage StrengthImg20;
	public RawImage StrengthImg30;
	public RawImage StrengthImg40;
	public RawImage StrengthImg50;
	public RawImage StrengthImg60;
	public RawImage StrengthImg70;
	public RawImage StrengthImg80;
	public RawImage StrengthImg90;
	public RawImage StrengthImg100;

	public void SetModel(ShieldModel model)
	{
		this.model = model;
	}

	public void SetView(ShieldView view)
	{
		this.view = view;
	}

	public void SetDamage1Text(Text Damage1)
	{
		this.Damage1 = Damage1;
	}

	public void SetDamage10Text(Text Damage10)
	{
		this.Damage10 = Damage10;
	}

	public void SetStrengthImage(RawImage StrengthImg){
		this.StrengthImg0 = StrengthImg0;
	}

	public void SetStrengthImage(RawImage StrengthImg){
		this.StrengthImg0 = StrengthImg0;
	}

	// .... Out Of Time Need More RawImage Setters

	private int GetDamageImage(){
		string strengthQuantity = model.GetStrength();
		if (strengthQuantity.Length > 90) {
			this.StrengthImg0 = StrengthImage100;
		} else if (strengthQuantity.Length > 90) {
			this.StrengthImg0 = StrengthImage90;
		} else if (strengthQuantity.Length > 10) {
			this.StrengthImg0 = StrengthImage10;
		} else {
			this.StrengthImg0 = StrengthImage0;
		}
	}

	public void EVENT_Damage()
	{
		int quantityOfDamage = GetDamageImage();
		model.TakeDamage(quantityOfDamage);
		view.Refresh();
	}
}