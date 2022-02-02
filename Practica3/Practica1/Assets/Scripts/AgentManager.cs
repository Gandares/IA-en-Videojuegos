using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{

    GameObject[] agents;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject a in agents){
            a.GetComponent<AIControl>().agent.SetDestination(player.GetComponent<Transform>().position);
        }
    }
}

