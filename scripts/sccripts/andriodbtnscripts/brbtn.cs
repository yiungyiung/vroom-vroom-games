using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class brbtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
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
         pla.GetComponent<movement>().spdown();
     }
 }
public void OnPointerDown(PointerEventData eventData){
     buttonPressed=true;
}
 
public void OnPointerUp(PointerEventData eventData){
    buttonPressed=false;
    pla.GetComponent<movement>().spup();
}
}

