using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRest : GAction
{
    public override bool PrePerform()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Moving");
        GWorld.Instance.GetWorld().RemoveState("monsterAppeared");
        return true;
    }

    public override bool PostPerform()
    {
        this.gameObject.GetComponent<Animator>().SetTrigger("Waiting");
        GWorld.Instance.Defeated();
        return true;
    }
}
