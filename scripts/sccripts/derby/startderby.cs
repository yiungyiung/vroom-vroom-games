using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class startderby : MonoBehaviour
{
    public float stim;
    public TMP_Text strat;
    public GameObject map;
    public GameObject pla;
    public GameObject ai1;
    public GameObject ai2;
    public GameObject ai3;
    public GameObject ai4;
    public GameObject ai5;
    public GameObject ai6;
    public GameObject ai7;
    public GameObject acc1;
    public GameObject bcc2;
    public GameObject br3;
    public GameObject strwh;
    // Start is called before the first frame update
    void Start()
    {
        stim=4.0f;
    }
    void Update()
    {
        stim-=Time.deltaTime;
        if (Mathf.Round(stim)<=1)
        {
        strat.text="GO!";
        Invoke("startplayers",0.2f);
        Invoke("rem",0.2f);
        startcont();}
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
void startplayers()
{
    
        
    ai1.SetActive(true);
    ai2.SetActive(true);
    ai3.SetActive(true);
    ai4.SetActive(true);
    ai5.SetActive(true);
    ai6.SetActive(true);
    ai7.SetActive(true);
    pla.SetActive(true);
    startcont();
    map.SetActive(true);
}
public void btnstart()
{
    gameObject.SetActive(true);
    
}

}