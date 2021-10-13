using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class accbtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
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
         pla.GetComponent<movement>().accdown();
     }
 }
public void OnPointerDown(PointerEventData eventData){
     buttonPressed=true;
}
 
public void OnPointerUp(PointerEventData eventData){
    buttonPressed=false;
    pla.GetComponent<movement>().accup();
}
}

