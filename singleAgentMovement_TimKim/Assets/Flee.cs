using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour {

    public GameObject fleeTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vectorToTarget = transform.position - fleeTarget.transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * .7f);
    }
}
