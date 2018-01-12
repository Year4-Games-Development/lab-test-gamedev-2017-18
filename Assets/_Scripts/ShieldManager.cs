using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour {
    private ShieldModel model;
    private ShieldView view;
    private ShieldController controller;

    public Text Strength;
    public Text isRepairable;

    private void Start()
    {
        model = new ShieldModel();

        view = new ShieldView();
        view.SetModel(model);
        view.SetText(Strength, isRepairable);
        view.TextAfterChanges();

        controller = new ShieldController();
        controller.SetModel(model);
        controller.SetView(view);
    }

    public void BUTTON_DoOneDamge()
    {
        controller.EVENT_DoDamage();
    }

    public void BUTTON_DoTenDamage()
    {
        controller.EVENT_DoMoreDamage();
    }

    public void BUTTON_DoTick()
    {
        controller.EVENT_Tick();
    }
}
