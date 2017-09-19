using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")){
			transform.Translate(Vector3.up * Time.deltaTime * 4.0f);
		}
		if (Input.GetKey("s")){
			transform.Translate(Vector3.down * Time.deltaTime * 4.0f);
		}
		if (Input.GetKey("a")){
			transform.Translate(Vector3.left * Time.deltaTime * 4.0f);
		}
		if (Input.GetKey("d")){
			transform.Translate(Vector3.right * Time.deltaTime * 4.0f);
		}
	}
}
