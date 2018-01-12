using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour
{
	private ShieldModel model;
	private ShieldView view;
	private ShieldController controller;

	public Text shieldStrengthText;
	public Text repairableText;
	public RawImage shieldStrengthImage;
	public Texture[] shieldStrengthTextures;

	void Start()
	{
		model = new ShieldModel ();

		view = new ShieldView ();
		view.Model = model;
		view.ShieldStrengthText = shieldStrengthText;
		view.RepairableText = repairableText;
		view.ShieldStrengthImage = shieldStrengthImage;
		view.ShieldStrengthTextures = shieldStrengthTextures;
		view.Refresh ();

		controller = new ShieldController ();
		controller.Model = model;
		controller.View = view;
	}

	public void OnTakeOneDamage()
	{
		controller.HandleDamage (1);
	}

	public void OnTakeTenDamange()
	{
		controller.HandleDamage (10);
	}

	public void OnTick()
	{
		controller.HandleTick ();
	}
}
