using UnityEngine;
using Boid;

public class Agent : IBoids
{
    private Vector3 v_Velocity;
    private Vector3 v_Pos;
    private float f_Mass;

    public Vector3 Velocity
    {
        get { return v_Velocity; }
        set { v_Velocity = value; }
    }

    public Vector3 Position
    {
        get { return v_Pos; }
        set { v_Pos = value; }
    }

    public float Mass
    {
        get { return f_Mass; }
        set { f_Mass = value; }
    }

    public Agent(float fM)
    {
        Velocity = new Vector3();
        Position = new Vector3();
        Mass = (fM <= 0) ? 1 : fM;
	}

    public void velocityUpdate()
    {
        Position += Velocity;
    }
}
