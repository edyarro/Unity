using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    /// <summary>
    /// player
    /// </summary>
    public Transform player;

    /// <summary>
    /// offset
    /// </summary>
    public Vector3 offset;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        this.transform.position = this.player.position + this.offset;
    }
}
