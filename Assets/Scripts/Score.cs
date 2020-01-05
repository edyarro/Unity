using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Score
/// </summary>
public class Score : MonoBehaviour
{
    /// <summary>
    /// player
    /// </summary>
    public Transform player;

    /// <summary>
    /// scoreText
    /// </summary>
    public Text scoreText;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        this.scoreText.text = this.player.position.z.ToString("0");
    }
}
