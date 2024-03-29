using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    private Transform canonTransform;
    private float xaxis;
    private float yaxis;
    [SerializeField] private float sensibiliteSpeed = 50f;

    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        canonTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        canonTransform.Rotate(Vector3.up, xaxis * sensibiliteSpeed * Time.deltaTime);
        canonTransform.Rotate(Vector3.right, yaxis * sensibiliteSpeed * Time.deltaTime);
        //canonTransform.rotation.Set(xaxis,yaxis,canonTransform.rotation.z,canonTransform.rotation.w);
        Debug.Log("aaah"+xaxis+yaxis);
        //fuckit
    }
    
    public void HandleMove(InputAction.CallbackContext inputContext)
    {
        xaxis = inputContext.ReadValue<Vector2>().x;
        yaxis = inputContext.ReadValue<Vector2>().y;
        Debug.Log("aaah"+xaxis+yaxis);
    }
}
