using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagewalls : MonoBehaviour
{   public AudioSource ch;
public int dam=10;
public GameObject startisai;
public bool ttruedam = false;
void Start()
{
    if(startisai.GetComponent<start>().ai==null)
    {
        ttruedam=true;
    }
}
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {   Debug.Log("whyy");
        if(ttruedam)
        {
            collision.gameObject.GetComponent<health>().dechealth(dam);}
            ch.Play();
        }
    }
}
