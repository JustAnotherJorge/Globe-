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
        var dir = Vector3.zero - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        angle += 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.Translate(Vector3.right * moveSpeed);
    }
}
