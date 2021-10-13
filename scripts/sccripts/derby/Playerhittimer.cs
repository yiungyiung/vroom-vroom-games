using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class Playerhittimer : MonoBehaviour
{
   public float hittimer = 30f;
   public Text hittimerr;
   public CinemachineVirtualCamera vcam;
   public GameObject deathloc;
   public GameObject own;
    // Update is called once per frame
    void Update()
    {   
       hittimer-=Time.deltaTime;
       hittimerr.text="Time left:"+System.Math.Round(hittimer,2);
       if(hittimer<=0)
       {
           hittimerr.text="ran out of time";
           vcam.Follow =deathloc.transform;
            vcam.m_Lens.OrthographicSize = 25f;
            
            gameObject.GetComponent<movement>().ts.Stop();
            gameObject.GetComponent<chnagederbyloc>().changeremaininglength();
           gameObject.SetActive(false);
            own.SetActive(false);
        }
    }

public void resettimer()
{
    hittimer=30f;
}

}
