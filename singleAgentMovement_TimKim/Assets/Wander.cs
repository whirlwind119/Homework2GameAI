using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {
	private Vector3 direction = new Vector3();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 target = direction  - transform.right * 5;
		target = new Vector3 (target.x + Random.Range (-1.0f, 1.0f), target.y + Random.Range (-1.0f, 1.0f), 0.0f) * 2;
		target.Normalize ();
		direction = target + transform.right * 5;

		Vector3 vectorToTarget = direction - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 1.5f);

		transform.Translate(Vector3.right * Time.deltaTime * 3);

	}
}
