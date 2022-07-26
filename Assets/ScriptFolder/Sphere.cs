using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sphere : MonoBehaviour
{

    void Start()
    {
        //Rigidbody rb = this.GetComponent<Rigidbody>();
        //Vector3 force = new Vector3(0.0f, 0.0f, 1.0f);
        //if (!_isGoal) rb.AddForce(force);
    }
    void Update()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (0.0f, 0.0f, 20.0f);
        if (this.transform.position.z >= 105) rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Item")
        Destroy(collision.gameObject);
    }

}
