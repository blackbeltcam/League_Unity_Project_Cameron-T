﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    bool grounded = false;
    float jump = 250;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)&& (grounded==true)){
            rb.AddForce(new Vector3(0, jump, 0));
        grounded = false;
        }
        transform.localScale = transform.localScale + new Vector3(0.001f, 0.001f, 0.001f);
        }
    public void OnCollisionEnter2D()
    {
        grounded = true;
    }
	}

