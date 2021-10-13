using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chnagederbyloc : MonoBehaviour
{   public GameObject own;
    public chnagederbyloc[] loc;
    public GameObject temp;
    public GameObject middlebody;
    
    
        
    void OnTriggerEnter2D(Collider2D col)
    {   wallhitchangeloc();}

    public void wallhitchangeloc()
    {
        if(gameObject.tag!="Player" )
    {   
        while(true)
        {
            
        temp=middlebody.GetComponent<dummy>().chnageloccen();
        //Debug.Log(temp.name);
        if(own.name!=temp.name && middlebody.GetComponent<dummy>().loca.Count>1)
        {
            break;
        }
        }
        //Debug.Log(temp.name+"target name"+own.name);
        gameObject.GetComponent<CarAIHandler>().changeloc(temp);
    }
    }
    public void changeremaininglength()
{
  middlebody.GetComponent<dummy>().loca.Remove(gameObject);  
}
    }

