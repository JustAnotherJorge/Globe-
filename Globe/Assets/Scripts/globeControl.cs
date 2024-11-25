using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeControl : MonoBehaviour
{
    [SerializeField] private float myRot;
    [SerializeField] private float rotSpeed = 1.0f;

    public bool _keyboardControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_keyboardControl == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                myRot -= 10;
            else if (Input.GetKey(KeyCode.LeftArrow))
                myRot += 10;
        }
        
        float targetAngle = Mathf.LerpAngle(transform.eulerAngles.y, -myRot, rotSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, targetAngle, transform.eulerAngles.z);

    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");

        if (!success)
        {
            _keyboardControl = true;
            rotSpeed = rotSpeed / 5;
        }
            
    }

    void OnMessageArrived(string msg)
    {
        if (_keyboardControl == false)
            myRot = float.Parse(msg);
    }
}
