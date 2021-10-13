using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menusc : MonoBehaviour
{  
    public string map;
    public bool racetrue=false;
    void start()
    {
      
      map="trialtrack";
      Debug.Log(map);
    }
    public void trial()
    { if(racetrue)
    {
      map="racetrialtrack";
    }
    else{
      map="trialtrack";}
    Debug.Log(map);
    }
    public void newtrack()
    {if(racetrue)
    {
      map="racenewtrack";
    }
    else{map="newtrack";}
    Debug.Log(map);}
    public void newtrack3()
    { if(racetrue)
    {
      map="racetrack3";
    }
      else
    {
      map="track3";}
      Debug.Log(map);
    }
    public void imap()
    { if(racetrue)
    {
      map="raceimap";
    }
      else
    {
      map="imap";}
      Debug.Log(map);
    }
    public void play()
    { 
      Debug.Log(map);
      SceneManager.LoadScene(map);  
    }
    public void racvsai()
    {
      map="race"+map;
      racetrue=true;
      Debug.Log(map);
    }
    public void racevstime()
    {
      if(map.Contains("race"))
      {
        //Debug.Log(map.Remove(4));
        map=map.Replace("race","");
        Debug.Log(map);
      }
      racetrue=false;
      Debug.Log(map);
    }
    public void quit()
    {   Debug.Log("quit");
        Application.Quit();
    }
    public void derby()
    {
      SceneManager.LoadScene("DERBY");
    }
}
