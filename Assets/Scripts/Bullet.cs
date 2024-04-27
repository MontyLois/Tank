using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;
using Object = System.Object;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float timeBeforeSelfDestruction;
    [SerializeField] private VFXRenderer vfx;
    public float speed;
    [SerializeField] public Animator animtor;
    
    [SerializeField] public GameObject vfxPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 5);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * speed;
    }
    

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, timeBeforeSelfDestruction);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log( other.gameObject);
        
        //Si en collision avec des objects destructibles, supprime ces derniers. 
         if (other.collider.CompareTag("Destructible"))
        {
            Destroy(other.gameObject);
        }

         //GameObject vfxInstance = Instantiate(vfxPrefab, other.contacts[0].point, Quaternion.identity);

         // Play the VFX
         //vfxPrefab.GetComponent<VisualEffect>().Play();
         
         // Destroy the object after the end of the vfx
        animtor.SetBool("Touchey", true);
        Destroy(this.gameObject, vfxPrefab.GetComponent<ParticleSystem>().duration);
    }
}
