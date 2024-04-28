using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    [SerializeField] private Turret_Canon mainWeapon;
    
    [SerializeField] public float baseSpeed = 10;
    [SerializeField] public float currentSpeed = 10;
    [SerializeField] public float speedBoost;
    [SerializeField] private float rotationSpeed = 25;
    

    private Transform localTransform;
    private Rigidbody tankRb;
    public float rotateAxis;
    public Vector3 moveVector;
    
    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
        tankRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        localTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);
        localTransform.Translate(moveVector * currentSpeed* Time.deltaTime);
        //tankRb.AddForce(moveVector, ForceMode.Impulse);
    }
    
    
    public void PrimaryAttaque()
    {
        mainWeapon.Shoot();
    }
    

    public void setTarget(Transform target)
    {
        mainWeapon.SetTarget(target);
    }
    
}
