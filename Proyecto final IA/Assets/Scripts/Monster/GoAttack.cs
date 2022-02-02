using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAttack : GAction
{
    public override bool PrePerform()
    {
        if (!GWorld.Instance.GetBoolMaxHealth()){
            GWorld.Instance.incrementHealth();
            return false;
        }
        this.gameObject.GetComponent<Animator>().SetTrigger("Moving");
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.GetWorld().ModifyState("monsterAppeared", 1);
        this.gameObject.GetComponent<Animator>().SetTrigger("Waiting");
        return true;
    }
}
