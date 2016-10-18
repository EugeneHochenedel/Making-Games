using UnityEngine;
using Boid;

public class OpenAgent : MonoBehaviour, IBoids
{
    private Agent bond;
    public float mass;

    public Vector3 Velocity
    {
        get { return bond.Velocity; }
        set { bond.Velocity = value; }
    }

    public Vector3 Position
    {
        get { return bond.Position; }
        set { bond.Position = value; }
    }

    float IBoids.Mass
    {
        get { return bond.Mass; }
        set { bond.Mass = value; }
    }

    void Start()
    {
        bond = new Agent(mass);
    }

    void LateUpdate()
    {
        bond.velocityUpdate();
    }
}


