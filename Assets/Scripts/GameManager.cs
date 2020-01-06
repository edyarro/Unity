using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// GameManager
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// gameHasEnded
    /// </summary>
    private bool gameHasEnded;

    /// <summary>
    /// restartDelay
    /// </summary>
    public float restartDelay;

    /// <summary>
    /// EndGame
    /// </summary>
    public void EndGame()
    {
        if (this.gameHasEnded == false)
        {
            Debug.Log("Game over");
            this.gameHasEnded = true;
            this.Invoke("Restart", this.restartDelay);
        }
    }

    /// <summary>
    /// Restart
    /// </summary>
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
