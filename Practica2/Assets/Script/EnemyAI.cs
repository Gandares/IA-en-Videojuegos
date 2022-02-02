using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Animator anim;
    public GameObject player;
    public GameObject bullet;
    public Transform canon;
    private Vector3 direction = Vector3.zero;
    float visDist = 20.0f;
    float visAttack = 10.0f;
    float visAngle = 30.0f;
    int salud = 100;
    bool healing = false;
    string state = "WANDER";
    
    public GameObject GetPlayer()
    {
        return player;
    }

    void setSalud(){
        salud++;
    }

    public void StopHealing()
    {
        CancelInvoke("setSalud");
    }
    public void StartHealing()
    {
        InvokeRepeating("setSalud", 0.2f, 0.2f);
    }

    public void StopShooting()
    {
        CancelInvoke("Shoot");
    }
    public void StartShooting()
    {
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        GameObject b = Instantiate(bullet, canon.position, canon.rotation);
        b.GetComponent<Rigidbody>().AddForce(canon.forward * 1000);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update(){

        direction = player.transform.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);

        if(salud <= 20){
            healing = true;
        }

        if(healing){
            if(salud >= 100){
                    healing = false;
            }
            if(state != "HIDE"){
                state = "HIDE";
                anim.SetTrigger("Hiding");
            }
        }
        else if((direction.magnitude >= visDist || angle >= visAngle)){
            if(state != "WANDER"){
                state = "WANDER";
                anim.SetTrigger("Wander");
            }
        }
        else if(direction.magnitude < visAttack && angle < visAngle){
            if(state != "ATTACK"){
                state = "ATTACK";
                anim.SetTrigger("Shooting");
            }
        }
        else if(direction.magnitude < visDist && angle < visAngle){
            if(state != "CHASE"){
                state = "CHASE";
                anim.SetTrigger("Chasing"); // Cambiar esto a variables como en lo otro
            }
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "bullet"){
            if(salud >= 0)
                salud-=20;
        }
    }
    
}
