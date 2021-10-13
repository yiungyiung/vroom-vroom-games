using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Racelaper : MonoBehaviour
{   
    int ailap=0;
    int plalap;
    public Text winext;
    bool alreadywon = false;
    public AudioSource as1;
    public AudioSource as2;    

    void Start()
    {
        ailap=0;
        Debug.Log("omega"+gameObject.GetComponent<laptimer>().i);
    }
    void Update()
    { if(!alreadywon)
    {
        if (plalap==5)
        {
            Debug.Log("player wins");
            winext.text="You wins";
            Invoke("restart12",2f);
            alreadywon = true;
            as1.Play();
        }
        else if(ailap==5)
        {
             Debug.Log("AI wins");
             winext.text="Computer wins";
             Invoke("restart12",2f);
             alreadywon = true;
             as2.Play();
             
        }
    }
    }
    // Start is called before the first frame update
   void OnTriggerEnter2D (Collider2D other)
     {
         if (other.gameObject.tag == "Player")
         {  
             plalap=gameObject.GetComponent<laptimer>().i;
             Debug.Log(plalap+"enteringyash1");
         }
         if (other.gameObject.tag == "AI")
         { Debug.Log(ailap+"enteringyash2");
             ailap+=1;
         }
}

public void restart12()
    {   
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

