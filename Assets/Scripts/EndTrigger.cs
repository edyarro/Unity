using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    /// <summary>
    /// gameManager
    /// </summary>
    public GameManager gameManager;

    /// <summary>
    /// OnTriggerEnter
    /// </summary>
    void OnTriggerEnter()
    {
        this.gameManager.CompleteLevel();
    }
}
