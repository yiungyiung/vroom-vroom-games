using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laptimer : MonoBehaviour
{   float besttime=100000000000;
    public int i;
    float a;
    public Text timer;
    public Text besttimer;
    public bool platrue;
    void Start()
    {
        i=0;
 platrue=false;
    }
    void OnTriggerEnter2D (Collider2D other)
     {
         if (other.gameObject.tag == "Player") 
         { if(!platrue){return;}
          i+=1;
            a=other.gameObject.GetComponent<timer>().t;
           timer.text="lap"+i+" : "+System.Math.Round(a,2);
           
             other.gameObject.GetComponent<timer>().t=0;
             other.gameObject.GetComponent<health>().inchealth(20);
             if(besttime>a)
             {
                 besttime=a;
                 besttimer.text="best time is : "+System.Math.Round(besttime,2);
                 platrue=false;

             }
             
         }
     }
 }

