using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcol : MonoBehaviour
{   public GameObject own;
public AudioSource as1;
void Start()
    {
      as1=(GameObject.FindWithTag("hitaud")).GetComponent<AudioSource>();;
    }
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {  //Debug.Log(own.name+"name"+collision.gameObject.name);
        if(own.name==collision.gameObject.name){return;}
        if(collision.gameObject.tag!="derbywall")
        {
            if(own.tag=="Player")
        {
          as1.Play();}
        //Debug.Log(collision.gameObject.name);
        collision.gameObject.GetComponent<derbhealth>().dechealth(10,own);
        }
        else{
            if(own.tag=="Player")
        {
          as1.Play();}
        }
        
    }
    
}
