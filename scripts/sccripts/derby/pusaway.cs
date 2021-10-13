using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusaway : MonoBehaviour
{   
    public GameObject cv;
    void Start()
    {
        cv=FindObjectOfType<dummy>().gameObject;
    }
 void OnCollisionEnter2D(Collision2D col)
    {   //Debug.Log("executing1");
        if (col.gameObject.tag!="derbywall" && cv.GetComponent<dummy>().loca.Count>1)
        {
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(col.gameObject.transform.up*-850f);
        col.gameObject.GetComponent<chnagederbyloc>().wallhitchangeloc();}
    }
}
