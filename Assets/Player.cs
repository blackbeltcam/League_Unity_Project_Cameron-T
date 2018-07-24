using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    float jump = 100;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.Space)){
            rb.AddForce(new Vector3(0, jump, 0));
        }
       
        }
	}

