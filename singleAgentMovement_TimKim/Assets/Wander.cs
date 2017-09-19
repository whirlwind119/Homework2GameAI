using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

	private Vector3 direction = new Vector3();
    Rigidbody2D rb;
    float timer = 7;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		DynamicWander ();

		Vector3 vectorToTarget = direction - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 1.5f);
        /*if (timer >= 7f) {
            rb.angularVelocity = Random.Range(-100f, 100f);
            timer = 0;
        }
        timer += Time.deltaTime;*/
		transform.Translate(Vector3.right * Time.deltaTime * 3);

	}

	void DynamicWander (){
		Vector3 target = direction - transform.forward*10.0f;
		target = new Vector3 (target.x + Random.Range(-5f, 5f), target.y + Random.Range(-5f, 5f),0.0f);
		target.Normalize();
		target = target * 4;
		direction = target + transform.forward*10.0f;
	}
}
