using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    private Transform canonTransform;
    [SerializeField] private Transform cible;
    private float xaxis;
    private float yaxis;
    [SerializeField] private float sensibiliteSpeed = 50f;
    [SerializeField] private float max_angle = 70;
    [SerializeField] private float min_angle = -70;
    
    [SerializeField] public GameObject bullet;
    [SerializeField] public Transform fireSource;
    [SerializeField] private float bulletForce = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        canonTransform = GetComponent<Transform>();
        Vector3 axis = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        canonTransform.LookAt(cible);
    }
    
    public void HandleMove(InputAction.CallbackContext inputContext)
    {
        xaxis = inputContext.ReadValue<Vector2>().x;
        yaxis = inputContext.ReadValue<Vector2>().y;
        
    }
    public void move()
    {
        float angle = canonTransform.rotation.x;
        Debug.Log(canonTransform.rotation.y+"aaah"+ angle);
        if ( angle <= max_angle && angle >= min_angle)
        {
            canonTransform.Rotate(Vector3.up, xaxis * sensibiliteSpeed * Time.deltaTime);
            canonTransform.Rotate(Vector3.left, yaxis * sensibiliteSpeed * Time.deltaTime);
        }
        canonTransform.rotation.Set(canonTransform.rotation.x, 0, canonTransform.rotation.z, 1);
    }
    
    public void HandleShoot(InputAction.CallbackContext inputContext)
    {
        Instantiate(bullet, fireSource.position, fireSource.rotation);
        
    }
}
