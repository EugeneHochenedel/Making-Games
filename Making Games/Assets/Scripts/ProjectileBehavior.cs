using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour
{
    OpenAgent j;
   
    public Transform targetPosition;
    Vector3 SteeringForce;
    Vector3 targetVelocity;
    public float Seek;

	// Use this for initialization
    void Start() { j = gameObject.GetComponent<OpenAgent>(); }

    // Update is called once per frame
    void FixedUpdate ()
    {
        //transform.position = transform.position + (currentVelocity / Mass).normalized;
        targetVelocity = (targetPosition.position - transform.position).normalized;
        SteeringForce = (targetVelocity - j.bond.Velocity).normalized * Seek;
        j.bond.Velocity += SteeringForce / j.bond.Mass;

        if(j.bond.Velocity.magnitude > 5)
        {
            j.bond.Velocity = j.bond.Velocity.normalized;
        }
	}
}
