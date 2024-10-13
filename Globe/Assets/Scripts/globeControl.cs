using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeControl : MonoBehaviour
{
    [SerializeField] private float myRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot -= 10;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot += 10;
        }

        transform.localEulerAngles = new Vector3(transform.eulerAngles.x, 0 + myRot, transform.eulerAngles.z);
    }
}
