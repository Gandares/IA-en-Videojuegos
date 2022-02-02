using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : GAction
{
    public override bool PrePerform()
    {
        if(!GWorld.Instance.GetWorld().HasState("guardArrived"))
            return false;
        this.gameObject.GetComponent<Animator>().SetTrigger("Attacking");
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
