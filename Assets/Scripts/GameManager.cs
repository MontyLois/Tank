using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private float timer = 0;
    
    // Event to notify when the score is updated
    public UnityEvent<int> OnScoreUpdated;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void IncrementScore(int points)
    {
        score += points;
        OnScoreUpdated.Invoke(score);
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Ending");
    }
}
