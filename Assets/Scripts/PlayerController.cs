using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int score = 0;
    public int health = 5;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            this.score += 1;
            Debug.Log("Score: " + score);
            other.GetComponent<Renderer>().enabled = false;
            Destroy(other);
        }
        if (other.tag == "Trap")
        {
            health -= 1;
            Debug.Log("Health: " + health);
        }
        
    }
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
