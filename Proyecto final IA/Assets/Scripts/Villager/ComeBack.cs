using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeBack : GAction
{
    public override bool PrePerform()
    {
        if(GWorld.Instance.GetWorld().HasState("monsterAppeared"))
            return false;
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
