using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeControl : MonoBehaviour
{
    [SerializeField] private float myRot;
    [SerializeField] private float rotSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRot -= 10;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRot += 10;
        }

        //transform.localEulerAngles = new Vector3(transform.eulerAngles.x, 0 + -myRot, transform.eulerAngles.z);
        //transform.eulerAngles = Vector3.Lerp( new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z), new Vector3(transform.eulerAngles.x, 0 + -myRot, transform.eulerAngles.z), 0.01f);
        float targetAngle = Mathf.LerpAngle(transform.eulerAngles.y, -myRot, rotSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, targetAngle, transform.eulerAngles.z);
    }

    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
    void OnMessageArrived(string msg)
    {
        myRot = float.Parse(msg);
    }
}
