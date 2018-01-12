using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController
{
    private ShieldModel sm;
    private ShieldView sv;

    public void SetModel(ShieldModel sm)
    {
        this.sm = sm;
    }

    public void SetView(ShieldView sv)
    {
        this.sv = sv;
    }

    //events
    public void EventDamage1()
    {
        sm.TakeDamage(1);
        sv.Refresh();
    }

    public void EventDamage10()
    {
        sm.TakeDamage(10);
        sv.Refresh();
    }

    public void EventTick()
    {
        sm.Tick();
        sv.Refresh();
    }
}
