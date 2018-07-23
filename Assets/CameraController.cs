using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	// Use this for initialization
	void Start () {
        for (int i = 0; i < 5; i++)
        {
            GameObject prefab = (GameObject)Instantiate(Resources.Load("FloorBlock"), new Vector3(i, 0, 0), Quaternion.identity);
        }

	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
