using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{

    public float speed;
    GameObject target;
    GameObject holder;
    public GameObject[] paths;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * .7f);
        */

        holder = findTarget();
        if(holder!= null)
        {
            target = holder;
            transform.Translate(Vector3.right * Time.deltaTime * 2);
        }

        //calculate the angle
        if (target != null)
        {
            Vector3 vectorToTarget = target.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * 1.5f);
        }




        /*
        //move forward
        //transform.position = new Vector3(transform.position.x + (this.speed * Time.deltaTime * Mathf.Cos(Quaternion.EulerAngles(transform.))), transform.position.y); 
        Vector3 rot = transform.rotation * Vector3.forward;
        Debug.Log(transform.position.x * rot.x * speed * Time.deltaTime); 
        transform.position = new Vector3(transform.position.x + rot.x * speed * Time.deltaTime, transform.position.y + rot.y * speed * Time.deltaTime, transform.position.z);
        */

    }

    public GameObject findTarget()
    {
        int i;
        for(i = 0; i < paths.Length; i++){
            if(paths[i].GetComponent<PathScript>().currentlyFalse() == true)
            {
                Debug.Log(paths[i]);
                return paths[i];
            }
        }
        return null;
    }
}
