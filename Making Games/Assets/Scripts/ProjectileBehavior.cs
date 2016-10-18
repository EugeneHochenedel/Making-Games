using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour
{
    //public Vector3 Force;
    //Vector3 currentVelocity;
    //public int Mass;

    public Transform targetPosition;
    Vector3 SteeringForce;
    Vector3 targetVelocity;
    public float Seek;

	// Use this for initialization
	void FixedUpdate ()
    {
        //transform.position = transform.position + (currentVelocity / Mass).normalized;

        //targetVelocity = (targetPosition.position - transform.position).normalized;
        //SteeringForce = (targetVelocity - currentVelocity).normalized / Mass;
        //currentVelocity = currentVelocity + SteeringForce;

        //if(currentVelocity.magnitude > 5)
        //{
        //    currentVelocity = currentVelocity.normalized;
        //}

	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        //transform.position += currentVelocity;
	}
}
