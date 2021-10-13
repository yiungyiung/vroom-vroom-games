using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soasda : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {   //Debug.Log("executing1");
        
        col.gameObject.GetComponent<Rigidbody2D>().AddForce(col.gameObject.transform.up*-500f);
        col.gameObject.GetComponent<chnagederbyloc>().wallhitchangeloc();}
    }

