using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class dummy : MonoBehaviour
{
 public chnagederbyloc[] loc;
 public List<GameObject> loca = new List<GameObject>();
 public List<GameObject> wina = new List<GameObject>();
 int itemIndex;
 int tempindex;
 int maxkills=0;
 int temp;
 public GameObject maxkiller;
 public TMP_Text wintext;
 public AudioSource win;
 public AudioSource loose;
 public GameObject pla;

    void Start()
    {
        loc=FindObjectsOfType<chnagederbyloc>();

        foreach(chnagederbyloc i in loc)
        {
            //Debug.Log("yash"+i.gameObject.name);
            //win.Play();
            loca.Add(i.gameObject);
            wina.Add(i.gameObject);
        }
        Debug.Log("count"+loca.Count);
        maxkiller=null;

    }

     void Update()
     {//Debug.Log("yas"+(Random.Range (0,4)));
         if(loca.Count==1)
         {  
             foreach(GameObject j in wina)
             {
              temp=j.GetComponent<derbhealth>().kills;
              if(temp>maxkills)
              {
                  maxkills=temp;
                  maxkiller=j;
              }   
             }
             if(maxkiller==pla)
             {  Debug.Log(win.isPlaying);
                
                 win.Play();
             }
             else{
                
                 loose.Play();
             }
             wintext.text=maxkiller.name+" wins with "+maxkiller.GetComponent<derbhealth>().kills+" kills";
             Debug.Log(maxkiller.name+" wins with "+maxkiller.GetComponent<derbhealth>().kills+" kills");
             loca[0].SetActive(false);
             gameObject.SetActive(false);
             Invoke("btnrestart",2f);
         }
         if(loca.Count==0)
         {  
             foreach(GameObject j in wina)
             {
              temp=j.GetComponent<derbhealth>().kills;
              if(temp>maxkills)
              {
                  maxkills=temp;
                  maxkiller=j;
              }   
             }
             if(maxkiller==pla)
             {  
                 if(!win.isPlaying)
                 win.Play();
             }
             else{
                 if(!loose.isPlaying)
                 loose.Play();
             }
             wintext.text=maxkiller.name+" wins with "+maxkiller.GetComponent<derbhealth>().kills+" kills";
             Debug.Log(maxkiller.name+" wins with "+maxkiller.GetComponent<derbhealth>().kills+" kills");
             gameObject.SetActive(false);
             Invoke("btnrestart",2f);
         }
     }
    public GameObject chnageloccen()
    {
        while(true)
        {
         itemIndex = Random.Range (0,loca.Count);
         //Debug.Log(itemIndex);
         
        if(loca[itemIndex].activeSelf)
        {
            break;
        }
        }
 return loca[itemIndex];
    }

    public void btnrestart()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
}

public void home()
{
   SceneManager.LoadScene("menu"); 
}

    }
