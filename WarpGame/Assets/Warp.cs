using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public float warpVelocity = 10000;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            //GetComponent<Rigidbody>().velocity = ;
            //GetComponent<Rigidbody>().velocity += this.transform.forward * warpVelocity;
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);

            if (Physics.Raycast(transform.position, forward, 10))
            {
                GetComponent<Rigidbody>().transform.position += this.transform.forward * warpVelocity;
                print("There is something in front of the object!");
            }
        }
        /*if (Input.GetButton("Fire1"))
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, forward, 10))
            {
                GetComponent<Rigidbody>().velocity += this.transform.forward * warpVelocity;
                print("There is something in front of the object!");
            }
        }*/

    }

    /*void FixedUpdate()
    {
        
    }*/
}
