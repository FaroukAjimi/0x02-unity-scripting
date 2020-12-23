using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = this.transform.position;
        pos.y = 1.200F;
        this.transform.position = pos;
        if (Input.GetKey(KeyCode.Q))
        {
            pos.x = pos.x - speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x = pos.x + speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            pos.z = pos.z + speed;
            this.transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.z = pos.z - speed;
            this.transform.position = pos;
        }        
    }
}
