using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private Tank tankScript;
    [SerializeField] private Health tankHealth;
    [SerializeField] private Curseur curseurScript;
    [SerializeField] private Transform curseurTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        tankScript.setTarget(curseurTransform);
    }

    // Update is called once per frame
    void Update()
    {
        if (tankHealth.lifePoint <= 0)
        {
            //gameover
        }
    }
    
    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        tankScript.rotateAxis = inputContext.ReadValue<float>();
    }
    
    public void HandleMove(InputAction.CallbackContext inputContext)
    {
        tankScript.moveVector = inputContext.ReadValue<float>() * Vector3.forward;
    }
    
    public void HandleSpeedBoost(InputAction.CallbackContext inputContext)
    {
        if (inputContext.ReadValue<float>() > 0)
        {
            tankScript.currentSpeed += tankScript.speedBoost;
        }
        else
        {
            tankScript.currentSpeed = tankScript.baseSpeed;
        }
    }
    
    public void HandleAim(InputAction.CallbackContext inputContext)
    {
        curseurScript.aimVector = inputContext.ReadValue<Vector2>();
    }
    
    public void HandleShoot(InputAction.CallbackContext inputContext)
    {
        tankScript.PrimaryAttaque();
    }
}
