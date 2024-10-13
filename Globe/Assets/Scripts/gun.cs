using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] private float shotiInterval = 1;
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", shotiInterval, shotiInterval);
    }

    void shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
