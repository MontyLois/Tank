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
    public float speed = 20f;
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
       
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("feur"+ other.gameObject);
         if (other.collider.CompareTag("Destructible"))
        {
            Destroy(other.gameObject);
        }

         //GameObject vfxInstance = Instantiate(vfxPrefab, other.contacts[0].point, Quaternion.identity);

         // Play the VFX
         //vfxPrefab.GetComponent<VisualEffect>().Play();
         
         // Destroy the VFX Prefab after it finishes playing
         
         animtor.SetBool("Touchey", true);
        Destroy(this.gameObject, vfxPrefab.GetComponent<ParticleSystem>().duration);
    }
}
