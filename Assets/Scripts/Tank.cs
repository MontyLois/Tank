using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tank : MonoBehaviour
{
    [SerializeField] float maxSpeed = 10;
    [SerializeField] private float rotationSpeed = 25;

    private Transform localTransform;
    private float rotateAxis;
    private Vector3 moveVector;
    
    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        localTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);
        localTransform.Translate(moveVector * Time.deltaTime);
    }
    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        rotateAxis = inputContext.ReadValue<float>();
    }
    
    public void HandleMove(InputAction.CallbackContext inputContext)
    {
        moveVector = inputContext.ReadValue<float>() * Vector3.forward * maxSpeed;
    }

    public void Aim()
    {
        
    }
    public void Shoot()
    {
        
    }

   
}
