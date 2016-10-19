using UnityEngine;
using System.Collections;
using Boid;

/// <summary>
/// Allows for access to values defined in the Agent class
/// </summary>

public class OpenAgent : MonoBehaviour
{
    public Agent bond;
    public float Mass;

    void Start() { bond = new Agent(Mass); }

    void LateUpdate()
    {
        bond.velocityUpdate();
        transform.position = bond.Position;
    }
}
