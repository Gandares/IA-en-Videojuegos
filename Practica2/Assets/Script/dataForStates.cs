using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataForStates : StateMachineBehaviour
{
    public GameObject NPC;
    public GameObject opponent;
    public UnityEngine.AI.NavMeshAgent agent;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC = animator.gameObject;
        opponent = NPC.GetComponent<EnemyAI>().GetPlayer();
        agent = NPC.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}
