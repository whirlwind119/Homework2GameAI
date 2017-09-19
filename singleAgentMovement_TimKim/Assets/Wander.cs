using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {

    Rigidbody2D rb;
    float timer = 7;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (timer >= 7f) {
            rb.angularVelocity = Random.Range(-100f, 100f);
            timer = 0;
        }
        timer += Time.deltaTime;
		transform.Translate(Vector3.right * Time.deltaTime * 3);

	}
}
