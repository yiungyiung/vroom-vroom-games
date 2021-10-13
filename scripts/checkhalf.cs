using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkhalf : MonoBehaviour
{   public GameObject start1;
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D col)
   {
       if (col.tag=="Player"){
           Debug.Log("working");
           start1.GetComponent<laptimer>().platrue=true;
       }
   }
}
