using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject bullet;
    public GameObject shotPoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject b = Instantiate(bullet,shotPoint.transform.position,shotPoint.transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(shotPoint.transform.forward * 1000);
        }
    }
}
