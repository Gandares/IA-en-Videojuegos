using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goRestGuard : GAction
{
    public override bool PrePerform()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Walking");
        GWorld.Instance.GetWorld().RemoveState("guardArrived");
        return true;
    }

    public override bool PostPerform()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Waiting");
        return true;
    }
}
