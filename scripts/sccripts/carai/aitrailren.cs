using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitrailren : MonoBehaviour
{
   public TrailRenderer tr;
   public TrailRenderer tr1;
   //public AudioSource ts;
   Rigidbody2D rb;
   void Start()
   {
       rb=gameObject.GetComponent<Rigidbody2D>();
   }
   void Update()
   {
       if(Mathf.Abs(Vector2.Dot(transform.right,rb.velocity))>5)
    {      
        tr.emitting=true;
        tr1.emitting=true;
        
    }
   else
    {
        tr.emitting=false;
        tr1.emitting=false; 
        
    }
   
   }
}
