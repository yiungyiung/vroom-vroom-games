using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{   public GameObject next;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="AI")
        {   //Debug.Log("entered");
            col.gameObject.GetComponent<CarAIHandler>().changeloc(next);
        }
    }
}
