using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Rb
    /// </summary>
    public Rigidbody Rb;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void FixedUpdate()
    {
        this.Rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
