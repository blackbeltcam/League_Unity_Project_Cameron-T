using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Vector3 last= new Vector3(-5,-5,0);
        Vector3 forward = new Vector3(0, 0, 0);
        for (int i = 0; i < 1000; i++)
        {
            GameObject prefab = (GameObject)Instantiate(Resources.Load("FloorBlock"),last+forward , Quaternion.identity);
            prefab.transform.Rotate(Vector3.forward, -45f );
            last = prefab.transform.position;
            forward = prefab.transform.right;

        }

	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = Quaternion.identity;
	}
}
