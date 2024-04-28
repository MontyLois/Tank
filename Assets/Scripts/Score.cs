using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    [SerializeField] private GameManager gameManager;
    private void Start()
    {
        // Subscribe to the score updated event
        gameManager.OnScoreUpdated.AddListener(UpdateScoreText);

        // Ensure the UI GameObject persists across scene loads
        DontDestroyOnLoad(gameObject);
    }

    private void UpdateScoreText(int score)
    {
        // Update the UI text with the current score
        scoreText.text = "Score: " + score;
    }
}
