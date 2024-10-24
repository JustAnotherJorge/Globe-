using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitEnemyMovment : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(Vector3.zero);
        transform.Translate(Vector3.right * moveSpeed);
    }
}
