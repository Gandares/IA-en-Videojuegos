using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager : GAgent
{
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("getTree", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("leaveWood", 1, false);
        goals.Add(s2, 4);

        SubGoal s4 = new SubGoal("comeBack", 1, false);
        goals.Add(s4, 5);
    }
}
