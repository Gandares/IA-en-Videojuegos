using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    new void Start()
    {
        GWorld.Instance.AddTree(this.gameObject);
    }
}
