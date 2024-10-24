using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallEnemyMovment : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Vector3.zero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
