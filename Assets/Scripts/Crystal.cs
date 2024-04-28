using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private Health crystalHealth;
    [SerializeField] private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (crystalHealth.lifePoint <= 0)
        {
            Invoke(nameof(DestroySelf), 0.5f);
        }
    }
    
    private void DestroySelf()
    {
        gameManager.IncrementScore(500);
        Destroy(gameObject);
    }
}
