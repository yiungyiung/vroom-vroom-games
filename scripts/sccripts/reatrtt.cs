using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reatrtt : MonoBehaviour
{   public GameObject pla;

    // Start is called before the first frame update
    public void restart()
    {
        pla=GameObject.FindWithTag("Player");
        pla.GetComponent<health>().healthh=0;
    }
    public void home()
    {
        SceneManager.LoadScene("menu");
    }

    
}
