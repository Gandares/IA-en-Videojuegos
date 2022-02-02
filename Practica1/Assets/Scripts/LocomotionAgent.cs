using UnityEngine;

[RequireComponent (typeof (UnityEngine.AI.NavMeshAgent))]
[RequireComponent (typeof (Animator))]
public class LocomotionAgent : MonoBehaviour {
	Animator anim;
	Vector3 lastPos;

	void Start () {
		anim = GetComponent<Animator>();
		lastPos = transform.position;
	}
	
	void Update () {
		if(CharMoved())
			anim.SetBool("move", true);
		else
			anim.SetBool("move", false);
	}

	public bool CharMoved(){
		var displacement = transform.position - lastPos;
		lastPos = transform.position;
  		return displacement.magnitude > 0.001;
	}
}
