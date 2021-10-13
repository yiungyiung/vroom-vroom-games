using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movementderby : MonoBehaviour
{
  public Rigidbody2D rb;
     float rotation;
     float x;
     float y;
     public int driftval=7;
     float time;
     public TrailRenderer tr;
      public TrailRenderer tr1;
      public ParticleSystem smoke;
      public AudioSource acc;
      public AudioSource ts;
      public ParticleSystem.EmissionModule psem;
        public Text spedd;
      public float movespeed=15f;
      public float maxspeed =35f;
     public float turnspeed = 1;
     public bool back;
     float perate=0.0f;
     public bool front;
     float a;
     public bool brake=true;
     public float accval =4.0f;
     public float brakeval=3.0f;
      ParticleSystem.MinMaxCurve tempCurve ;
   
      
     
    void Start()
    
    { psem=smoke.emission;
        tr.emitting=false;
        tr1.emitting=false;
        time = Time.time;
        
    }
    void Update()
    {   //spedd.text=(((int)rb.velocity.magnitude)*4).ToString()+"km/hr";
       
       
        
        if((int)rb.velocity.magnitude==0)
        {
            ts.Stop();
        }
        if (front&& brake)
         {perate=15;
           tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
              }
        if (Input.GetKeyUp(KeyCode.Space))
         {  
            spup();
         }
         if (Input.GetKeyUp(KeyCode.UpArrow))
         {
             
            accup();
            
         }  
         
          if (Input.GetKeyUp(KeyCode.DownArrow))
         {
            bwup();
         }
    

    }
     // Update is called once per frame
     void FixedUpdate()
     {  
           //Debug.Log(rb.velocity.magnitude+"yash");
     if (!brake && front)
     {      Debug.Log("123yash");
            perate=25;
            tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
              
     }
          if (Input.GetKey(KeyCode.Space))
         {  
         spdown();
         }
      
      //Debug.Log(a);
    if(Mathf.Abs(Vector2.Dot(transform.right,rb.velocity))>driftval)
    {   
        tr.emitting=true;
        tr1.emitting=true;
        if(!ts.isPlaying)
            {
            ts.Play();}
    }
    else if (!brake)
    { /*perate=15;
            tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
            tempCurve2.constant = perate;
            psem2.rateOverTime = tempCurve2;*/
        tr.emitting=true;
        tr1.emitting=true;
        if(!ts.isPlaying)
            {
            ts.Play();}
    }
    else
    { /*perate=0;
            tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
            tempCurve2.constant = perate;
            psem2.rateOverTime = tempCurve2;*/
        tr.emitting=false;
        tr1.emitting=false; 
        ts.Stop();
    }
        
         if (Input.GetKey(KeyCode.UpArrow))
         {
             accdown();
         }
         
         
         
         if (Input.GetKey(KeyCode.DownArrow))
         {  
             bwdown();
         }
        
         if((int)rb.velocity.magnitude!=0)
         {
             //Debug.Log(rb.velocity.magnitude);
             if (back){
                 rb.rotation = rotation + Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
             }
             else
             {
 rb.rotation = rotation - Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
             }
      
       rotation=Mathf.Deg2Rad* rotation;
       rotation = rb.rotation; 
     }
     /*if (Input.GetKey(KeyCode.Space))
         {
            rb.drag=10;
            rb.rotation = rotation - Input.GetAxisRaw("Horizontal")*turnspeed*Time.deltaTime*10;
         //rb.velocity*=0.0001f;
         }
         if (Input.GetKeyUp(KeyCode.Space))
         {
            rb.drag=5;
         //rb.velocity*=0.0001f;
         }*/
     }

    

    public void accdown()
    {   if(brake)
    {
        rb.drag=1.5f;
             rb.AddForce(transform.up* movespeed );
             rb.rotation = rotation - Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
            front=true;
            perate=15;
           tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
            movespeed +=accval;
            if (movespeed >=maxspeed)
            {
                movespeed=maxspeed;
            }
            if(!acc.isPlaying)
            {
            acc.Play();}}
    }

    public void accup()
    {
        if(brake)
        {
            movespeed=15f;
            perate=0;
            tempCurve.constant = perate;
            psem.rateOverTime = tempCurve;
            rb.drag=1.8f;
            front= false;
            acc.Stop();
        }
    }

    public void bwdown()
    {
        if (brake)
        {
            rb.drag=1.8f;
            back=true;
             rb.AddForce(transform.up * -1.0f *12 );
             rb.rotation = rotation + Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
            if(!acc.isPlaying)
            {
            acc.Play();}
        }
    }

    public void bwup()
    {
       if(brake)
       {
           rb.drag=0.7f;
            Debug.Log("entering123");
           back=false;
           acc.Stop();
       } 
    }
    public void spup()
    {
            tr.emitting=false;
            tr1.emitting=false;
            brake=true;
    }

    public void spdown()
    {
        if(Time.time >= time + 0.5f)
        {
            brake=false;
        
             if(Mathf.Abs(Vector2.Dot(transform.right,rb.velocity))>7)
             {
                 rb.drag=0;
             }
             else if((int)rb.velocity.magnitude>21)
             {
                 rb.drag=0.5f;
             }
             else  {
                 rb.drag=3;
             }
            rb.velocity=rb.velocity/brakeval;
            //Debug.Log(rb.velocity.magnitude);
            time = Time.time;
            if (back){
                 rb.rotation = rotation + Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
             }
             else
             {
 rb.rotation = rotation - Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime*10;
             }
        }
    }
}

