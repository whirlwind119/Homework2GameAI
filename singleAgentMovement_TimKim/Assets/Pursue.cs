using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : MonoBehaviour {

    public float speed;
    public GameObject target;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        /*Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * .7f);
        */
		transform.Translate(Vector3.right * Time.deltaTime * Vector3.Magnitude(transform.position - target.transform.position));
       
       
        //calculate the angle
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 1.5f);




        /*
        //move forward
        //transform.position = new Vector3(transform.position.x + (this.speed * Time.deltaTime * Mathf.Cos(Quaternion.EulerAngles(transform.))), transform.position.y); 
        Vector3 rot = transform.rotation * Vector3.forward;
        Debug.Log(transform.position.x * rot.x * speed * Time.deltaTime); 
        transform.position = new Vector3(transform.position.x + rot.x * speed * Time.deltaTime, transform.position.y + rot.y * speed * Time.deltaTime, transform.position.z);
        */

    }
}
