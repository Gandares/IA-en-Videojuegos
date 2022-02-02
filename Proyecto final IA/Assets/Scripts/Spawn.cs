using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject tree;
    public int numMaxTrees = 5;
    private float areaXY = 10f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject g = Instantiate(tree, this.transform.position + new Vector3(Random.Range(-areaXY,areaXY),0,Random.Range(-areaXY,areaXY)), Quaternion.Euler(0,Random.Range(0f,360f),0));
        }

        Invoke("SpawnTree", 5);
    }

    void SpawnTree()
    {
        if(GWorld.Instance.getNumTrees() < numMaxTrees){
            GameObject g = Instantiate(tree, this.transform.position + new Vector3(Random.Range(-areaXY,areaXY),0,Random.Range(-areaXY,areaXY)), Quaternion.Euler(0,Random.Range(0f,360f),0));
        }
        Invoke("SpawnTree", Random.Range(4, 8));
    }
}
