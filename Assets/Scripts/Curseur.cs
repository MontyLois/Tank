using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Curseur : MonoBehaviour
{
    private Camera maincam;

    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float sensibility;
    [SerializeField] private float maxHigh;
    [SerializeField] private float minHigh;
    [SerializeField] private float maxwidth;
    [SerializeField] private float minwidth;

    
    
    private Transform curseurTransform;
   

    private Vector2 axis;

    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false; 
        curseurTransform = GetComponent<Transform>();
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // if ((curseurTransform.localPosition.y < maxHigh && axis.y > 0 )||(curseurTransform.localPosition.y > minHigh && axis.y < 0) )
        // {
        //    curseurTransform.Translate(new Vector3(0, axis.y, 0) * sensibility * Time.deltaTime);
        // }
        //
        // if ((curseurTransform.localPosition.x < minwidth && axis.x > 0 )||(curseurTransform.localPosition.x > maxwidth && axis.x < 0) )
        // {
        //     curseurTransform.Translate(new Vector3(axis.x, 0, 0) * sensibility * Time.deltaTime);
        // }

        //curseurTransform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        curseurTransform.position = maincam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, maincam.farClipPlane));
        
        //Input.mousePositionDelta.magnitude
    }

   
    
    public void HandleMove(InputAction.CallbackContext inputContext)
    {
        axis = inputContext.ReadValue<Vector2>();
       
       
        //moveVector = inputContext.ReadValue<float>() * Vector3.forward;
    }
}
