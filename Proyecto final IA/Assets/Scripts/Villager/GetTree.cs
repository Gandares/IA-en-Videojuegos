using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTree : GAction
{
    public override bool PrePerform()
    {
        if(GWorld.Instance.GetWorld().HasState("monsterAppeared"))
            return false;
        target = GWorld.Instance.RemoveTree();
        if (target == null)
            return false;
        return true;
    }

    public override bool PostPerform()
    {
        Destroy(target);
        return true;
    }
}
