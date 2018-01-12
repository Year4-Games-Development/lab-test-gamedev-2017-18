
using UnityEngine.UI;
using UnityEngine;

public class ShieldManager : MonoBehaviour
{
    private ShieldController sc;
    private ShieldModel sm;
    private ShieldView sv;
    public Text TextShieldStrengthValue;
    public Text TextRepairableValue;

    // Use this for initialization
    void Start ()
    {
        sm = new ShieldModel();
        sv = new ShieldView();
        sv.SetModel(sm);
        sv.SetUiText(TextShieldStrengthValue, TextRepairableValue);
        sv.Refresh();
        sc = new ShieldController();
        sc.SetModel(sm);
        sc.SetView(sv);    
	}

    public void Damage1Button()
    {
        sc.EventDamage1();
    }

    public void Damage10Button()
    {
        sc.EventDamage10();
    }

    public void TickButton()
    {
        sc.EventTick();
    }
}
