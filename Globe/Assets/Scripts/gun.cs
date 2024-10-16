using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] private float shotiInterval = 1;
    [SerializeField] private GameObject bullet;

    [SerializeField] private int ammo = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(2 * transform.position - Vector3.zero);

        InvokeRepeating("shoot", shotiInterval, shotiInterval);
    }

    void shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        ammo--;

        if (ammo == 0)
            Destroy(gameObject);
    }
}
