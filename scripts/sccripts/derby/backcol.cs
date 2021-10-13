using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backcol : MonoBehaviour
{
    public GameObject own;
    public AudioSource as1;
    void Start()
    {
      as1=(GameObject.FindWithTag("hitaud")).GetComponent<AudioSource>();;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {  //Debug.Log(own.name+"name"+collision.gameObject.name);
      if(own.name==collision.gameObject.name){return;}
      if(collision.gameObject.tag!="derbywall")
        { if(own.tag=="Player")
        {
          as1.Play();}
        own.GetComponent<derbhealth>().dechealth(3,collision.gameObject);}
        else
        {
          if(own.tag=="Player")
        {
          as1.Play();}
          own.GetComponent<chnagederbyloc>().wallhitchangeloc();  
        }}
}
