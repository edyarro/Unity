using UnityEngine;

/// <summary>
/// PlayerCollision
/// </summary>
public class PlayerCollision : MonoBehaviour
{
    /// <summary>
    /// movement
    /// </summary>
    public PlayerMovement movement;

    /// <summary>
    /// When two object with RigidBody and Collider collide
    /// </summary>
    /// <param name="collisionInfo"></param>
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
        }
    }
}
