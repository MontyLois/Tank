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
    
    [SerializeField] public float sensibility;
    private Transform curseurTransform;
    public Vector2 aimVector;

    
    // Start is called before the first frame update
    void Start()
    {
        curseurTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        curseurTransform.Translate(aimVector * sensibility* Time.deltaTime);
    }
}
