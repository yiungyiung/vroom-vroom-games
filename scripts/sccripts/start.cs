using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{   public Text strat;
    public GameObject ai;
    //public GameObject ai2;

    public float stim;
    public GameObject pla;
    public GameObject pla2;
    public GameObject pla3;
    public GameObject pla4;
    public AudioSource ig;
    public int car;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public CinemachineVirtualCamera vcam;
    public Text chos;
    public int notai=0;
    public GameObject acc1;
    public GameObject bcc2;
    public GameObject br3;
    public GameObject strwh;

    void Start()
    {   
        if(ai==null)
        {
            //ai=null;

            notai=1;
            Debug.Log(" " + notai);

        }
        stim=4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        stim-=Time.deltaTime;
        if (Mathf.Round(stim)<=1)
        {
            strat.text="GO";
            if(!ig.isPlaying)
            {
            ig.Play();}

            if(car==1)
            {
            pla.SetActive(true);
            vcam.LookAt = pla.transform;
            vcam.Follow = pla.transform;
            startai();
            Invoke("rem",0.5f);
            startcont();}
            else if(car==2)
            {
                pla2.SetActive(true);
                vcam.LookAt = pla2.transform;
            vcam.Follow = pla2.transform;
            startai();
            Invoke("rem",0.5f);
            startcont();}
            
            else if(car==3)
            {
                pla3.SetActive(true);
                vcam.LookAt = pla3.transform;
            vcam.Follow = pla3.transform;
            startai();
            Invoke("rem",0.5f);
            startcont();}
            
            else if(car==4)
            {
                pla4.SetActive(true);
                vcam.LookAt = pla4.transform;
                vcam.Follow = pla4.transform;
                startai();
                Invoke("rem",0.5f);
                startcont();}
            
        }
        else
        {
        strat.text=""+((int)stim);
        }
    }
    void startcont()
    {   Debug.Log("notm");
        if(true)
    {
        acc1.SetActive(true);
        bcc2.SetActive(true);
        br3.SetActive(true);
        strwh.SetActive(true);}
    }
   void rem()
   {
       strat.text="";
       
       gameObject.SetActive(false);
   }
   public void startai()
   {    Debug.Log(notai);
       if(notai==0)
   {   
       if(SceneManager.GetActiveScene().name=="derby")
   {
       gameObject.GetComponent<starai>().startaii();
   }
       Debug.Log("yes1");
       ai.SetActive(true);
       //ai2.SetActive(true);
       }
   }
    public void carchooseviper()
    {
        car=2;
        chos.gameObject.SetActive(false);
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        Button3.gameObject.SetActive(false);
        Button4.gameObject.SetActive(false);
        gameObject.SetActive(true);
        
    }
   public  void carchooseaudi()
    {
        car=1;
        chos.gameObject.SetActive(false);
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        Button3.gameObject.SetActive(false);
        Button4.gameObject.SetActive(false);
        gameObject.SetActive(true);
        
    }
    public  void carchoosecar()
    {
        car=3;
        chos.gameObject.SetActive(false);
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        Button3.gameObject.SetActive(false);
        Button4.gameObject.SetActive(false);
        gameObject.SetActive(true);
        
    }
    public  void carchoosetruck()
    {
        car=4;
        chos.gameObject.SetActive(false);
        Button1.gameObject.SetActive(false);
        Button2.gameObject.SetActive(false);
        Button3.gameObject.SetActive(false);
        Button4.gameObject.SetActive(false);
        gameObject.SetActive(true);
        
    } 
}

