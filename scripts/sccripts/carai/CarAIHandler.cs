using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CarAIHandler : MonoBehaviour
{
    public enum AIMode { followPlayer, followWaypoints, followMouse };

    [Header("AI settings")]
    public AIMode aiMode;
    public float maxSpeed = 16;
    public bool isAvoidingCars = true;
    GameObject[] m;
    public int i=0;

    //Local variables
    Vector3 targetPosition = Vector3.zero;
    //Transform targetTransform = null;

    //Avoidance
    Vector2 avoidanceVectorLerped = Vector3.zero;

    //Waypoints
    GameObject currentWaypoint = null;
    WaypointNode[] allWayPoints;

    //Colliders
    PolygonCollider2D polygonCollider2D;

    //Components
    TopDownCarController topDownCarController;
    public GameObject fisloc;

    //Awake is called when the script instance is being loaded.
    void Awake()
    {
        topDownCarController = GetComponent<TopDownCarController>();
        allWayPoints = FindObjectsOfType<WaypointNode>();
        m=GameObject.FindGameObjectsWithTag("loca");

        //polygonCollider2D = GetComponentInChildren<PolygonCollider2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        m=GameObject.FindGameObjectsWithTag("loca");
        currentWaypoint=fisloc;
    }
    // Update is called once per frame and is frame dependent
    void FixedUpdate()
    {
        Vector2 inputVector = Vector2.zero;

        FollowWaypoints();

        inputVector.x = TurnTowardTarget();
        inputVector.y = ApplyThrottleOrBrake(inputVector.x);

        //Send the input to the car controller.
        //Debug.Log(inputVector.y+"yash"+inputVector.x);
        topDownCarController.SetInputVector(inputVector);
    }

    //AI follows player


    //AI follows waypoints
    void FollowWaypoints()
    {
        //Pick the cloesest waypoint if we don't have a waypoint set.

        //Set the target on the waypoints position
        if (currentWaypoint != null)
        { 
            //Set the target position of for the AI. 
            /*targetPosition = Vector3.Lerp(currentWaypoint.transform.position - currentWaypoint.transform.right, 
		                      currentWaypoint.transform.position + currentWaypoint.transform.right, 
		                      Random.value);*/
             //targetPosition =   currentWaypoint.transform.position;            
           //Debug.Log(targetPosition+" OMG "+currentWaypoint.transform.position);

            //Store how close we are to the target
            float distanceToWayPoint = (targetPosition - transform.position).magnitude;

            //Check if we are close enough to consider that we have reached the waypoint
            
        }
    }

    //AI follows the mouse position
   

    //Find the cloest Waypoint to the AI
    public void  changeloc(GameObject next)
    {   
        currentWaypoint=next;}    

    float TurnTowardTarget()
    {
        
        targetPosition =   currentWaypoint.transform.position;  
        //Apply avoidance to steering
        Vector2 vectorToTarget = targetPosition - transform.position;
        vectorToTarget.Normalize();
        

        //Calculate an angle towards the target 
        float angleToTarget = Vector2.SignedAngle(transform.up, vectorToTarget);
        angleToTarget *= -1;

        //We want the car to turn as much as possible if the angle is greater than 45 degrees and we wan't it to smooth out so if the angle is small we want the AI to make smaller corrections. 
        float steerAmount = angleToTarget / 45.0f;

        //Clamp steering to between -1 and 1.
        steerAmount = Mathf.Clamp(steerAmount, -1.0f, 1.0f);

        return steerAmount;
    }

    float ApplyThrottleOrBrake(float inputX)
    {
        //If we are going too fast then do not accelerate further. 
    

        //Apply throttle forward based on how much the car wants to turn. If it's a sharp turn this will cause the car to apply less speed forward.
        return 1.05f - Mathf.Abs(inputX) / 1.0f;
    }

    //Checks for cars ahead of the car.
    

} 
