using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView{
    private ShieldModel model;
    private Text Strength;
    private Text isRepairable;

    private RawImage[] shieldStrength;

    public void SetModel(ShieldModel model)
    {
        this.model = model;
    }

    public void SetText(Text Strength, Text isRepairable)
    {
        this.Strength = Strength;
        this.isRepairable = isRepairable;
    }

    public void SetImage(RawImage shieldStrength)
    {

    }

    public void TextAfterChanges()
    {
        this.Strength.text = model.GetStrength().ToString();
        this.isRepairable.text = model.IsRepairable().ToString();
    }

}
