using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;


public class derbhealth : MonoBehaviour
{   
public int kills;
public int health =100;
public GameObject own;
public GameObject Temp;
public GameObject deathloc;
//public GameObject killer;
public TMP_Text healthtext;
public TMP_Text killfeed;
public TMP_Text kill;
public CinemachineVirtualCamera vcam; 

void Update()
{   
    if (gameObject.tag=="Player")
{
healthtext.text="Health : "+health;
kill.text="Kills : "+kills;
}
}
    



    public void dechealth(int dam,GameObject temp)
    {   
        //killer=temp;
        health-=dam;
        if(temp.tag=="Player")
        {
            temp.GetComponent<Playerhittimer>().resettimer();
        }
        if(own.tag=="Player")
        {
            own.GetComponent<Playerhittimer>().resettimer();
        }
        if(health<=0)
        {   
            //Temp=temp;
            dead(own,temp);
        }
        
    }
    public void dead(GameObject own , GameObject killer)
    {   
        //Debug.Log("executed");
        if(killer!=Temp)
    {   
        Temp=killer;
        //Debug.Log("executed");
        if (own.tag=="Player")
        {
        healthtext.text="Dead";
        vcam.Follow =deathloc.transform;
        vcam.m_Lens.OrthographicSize = 25f;
        own.GetComponent<movement>().ts.Stop();
        }
        killfeed.text="";
        killfeed.text=killer.name+" killed "+own.name;
        Debug.Log(own.name+" died by "+killer.name);
        killer.GetComponent<derbhealth>().killup();
        own.GetComponent<chnagederbyloc>().changeremaininglength();
        own.SetActive(false);

    
    }}
    public void killup()
    {
        kills+=1;
    }
}

