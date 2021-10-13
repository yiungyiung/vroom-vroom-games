using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{   public float t;
public Text tmer;
    // Start is called before the first frame update
    void Start()
    {
        t=0;
    }

    // Update is called once per frame
    void Update()
    {
       tmer.text=System.Math.Round(t,2).ToString();
       t=t+Time.deltaTime; 
    }
}
