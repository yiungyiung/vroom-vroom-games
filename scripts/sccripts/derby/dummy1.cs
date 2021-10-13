using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummy1 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {   //col.GetComponent<chnagederbyloc>().wallhitchangeloc();
        try
        {
            col.transform.parent.gameObject.GetComponent<chnagederbyloc>().wallhitchangeloc();
        }
        catch
        {
           col.gameObject.GetComponent<chnagederbyloc>().wallhitchangeloc();
        }
}
}

