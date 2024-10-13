using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(Vector3.up, rotationSpeed);
    }
}
