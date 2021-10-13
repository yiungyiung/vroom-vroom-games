using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{   public int healthh =100;
    public Text healthbar;
    bool death=false;
    public Text restarting;
    string sname;
    

    // Update is called once per frame
    void Update()
    { if (death)
    {
        return;
    }
      healthbar.text="Health:"+healthh;
      if (healthh<=0){
          GameObject.FindWithTag("Player").SetActive(false);
          restarting.text="Restarting......";
          Invoke("restart1", 2);
        death = true;
      }  
    }
    public void dechealth(int dam)
    {   
        //Debug.Log(dam);
        healthh-=dam;
    }
    public void inchealth(int dam)
    {   
       healthh+=dam;
       if (healthh>100)
       {
           healthh=100;
       } 
    }
    public void restart1()
    {   
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
