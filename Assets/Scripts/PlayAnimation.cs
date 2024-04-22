using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    [SerializeField]  private Object mainProjectile;

    [SerializeField] private ParticleSystem mainParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("feur"+ other.gameObject);
        if (other.collider.CompareTag("Destructible"))
        {
            Destroy(other.gameObject);
        }

        // Play the VFX
        mainParticleSystem.Play();

        float timer = mainParticleSystem.duration;
        // Destroy the VFX Prefab after it finishes playing
        Destroy(this.gameObject, timer);
    }
}
