using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minifolow : MonoBehaviour
{
    public Transform pla;

    void LateUpdate()
{
    Vector3 newpos= pla.position;
    newpos.y=transform.position.y;
    transform.position=newpos;
    //transform.rotation=Quaternion.Euler(90f,pla.eulerAngles.y,0f);
}
}
