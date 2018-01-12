using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldController{
    private ShieldView view;
    private ShieldModel model;

    private Text Strength;

    public void SetView(ShieldView view)
    {
        this.view = view;
    }

    public void SetModel(ShieldModel model)
    {
        this.model = model;
    }

    public void SetStrength(Text strength)
    {
        this.Strength = Strength;
    }

    private int GetShieldDamage()
    {
        string damageString = Strength.text;
        
            if(damageString.Length > 90)
        {
            damageString = "100";
        }
        int damage = int.Parse(damageString);
        return damage;
    }
}
