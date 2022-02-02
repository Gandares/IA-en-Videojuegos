using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("goAttack", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("goRest", 1, false);
        goals.Add(s2, 4);
    }
}
