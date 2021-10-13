using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class bccbtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
public GameObject pla;
public bool buttonPressed;
void Awake()
{   if(pla==null)
{
    pla=GameObject.FindWithTag("Player");}
}

void FixedUpdate()
 
 {
     if(buttonPressed)
     {
         pla.GetComponent<movement>().bwdown();
     }
 }
public void OnPointerDown(PointerEventData eventData){
     buttonPressed=true;
}
 
public void OnPointerUp(PointerEventData eventData){
    buttonPressed=false;
    pla.GetComponent<movement>().bwup();
}
}

