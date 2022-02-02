using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDefend : GAction
{
    public override bool PrePerform()
    {
        if(!GWorld.Instance.GetWorld().HasState("monsterAppeared"))
            return false;
        this.gameObject.GetComponent<Animator>().SetTrigger("Walking");
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("guardArrived", 1);
        return true;
    }
}
