using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Rb
    /// </summary>
    public Rigidbody Rb;

    /// <summary>
    /// forwardForce
    /// </summary>
    public float forwardForce = 2000f;

    /// <summary>
    /// sidewaysForce
    /// </summary>
    public float sidewaysForce = 500;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            this.Rb.AddForce(this.sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            this.Rb.AddForce(-this.sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            this.Rb.AddForce(0, 0, this.sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            this.Rb.AddForce(0, 0, -this.sidewaysForce * Time.deltaTime);
        }
    }
}
