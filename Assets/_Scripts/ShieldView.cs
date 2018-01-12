using UnityEngine.UI;

public class ShieldView
{
    private ShieldModel sm;
    private Text TextShieldStrengthValue;
    private Text TextRepairableValue;

    public void SetModel(ShieldModel sm)
    {
        this.sm = sm;
    }

    public void SetUiText(Text TextShieldStrengthValue, Text TextRepairableValue)
    {
        this.TextShieldStrengthValue = TextShieldStrengthValue;
        this.TextRepairableValue = TextRepairableValue;
    }

    public void Refresh()
    {
        this.TextShieldStrengthValue.text = sm.GetStrength().ToString();
        this.TextRepairableValue.text = sm.IsRepairable().ToString();
    }
}
