using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * This script handle the turret movements
 */
public class Turret_Canon : MonoBehaviour
{
    [SerializeField] private Transform canonBase;
    [SerializeField] private Transform turretBase;
    [SerializeField] private Transform cible;
    private float xaxis;
    private float yaxis;
   
    [SerializeField] public GameObject bullet;
    [SerializeField] public Transform fireSource;
    public float cooldownTime = 0.5f; // Cooldown time between shots
    private float cooldownTimer = 0f; // Timer for tracking cooldown

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        cooldownTimer -= Time.deltaTime;
    }

    private void Move()
    {
        //make the turret face the target
        turretBase.LookAt(cible);
        //reset the turret rotation so it will only rotate on the y axis
        turretBase.rotation.Set(0, turretBase.rotation.y, 0, 1);
        //make the canon face the target
        canonBase.LookAt(cible);
    }

    public void SetTarget(Transform target)
    {
        //set the target to look at
        cible = target;
    }

    public void Shoot()
    {
        if (cooldownTimer <= 0)
        {
            //Spawn bullet
            Instantiate(bullet, fireSource.position, fireSource.rotation);
            
            // Reset the cooldown timer
            cooldownTimer = cooldownTime;
        }
    }
}
