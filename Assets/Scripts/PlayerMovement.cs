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
    public float forwardForce;

    /// <summary>
    /// sidewaysForce
    /// </summary>
    public float sidewaysForce;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void FixedUpdate()
    {
        this.Rb.AddForce(0, 0, this.forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            this.Rb.AddForce(this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            this.Rb.AddForce(-this.sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            this.Rb.AddForce(0, 0, -this.sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
