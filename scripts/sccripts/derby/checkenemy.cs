using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkenemy : MonoBehaviour
{
void Update()
{

checkenemy1();
}
public void checkenemy1()
{
    Debug.Log(Physics2D.OverlapCircle(transform.position,10).name+"yash");
}
}
