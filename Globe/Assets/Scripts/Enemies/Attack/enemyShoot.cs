using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;
using UnityEngine.Events;

public class enemyShoot : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    [Header("Auto Shoot Sttings")]
    [SerializeField] private bool autoShoot;
    [SerializeField] private float fireRate = 1;


    // Start is called before the first frame update
    void Start()
    {
        if (autoShoot == true)
            InvokeRepeating("shoot", fireRate, fireRate);
    }

    public void shoot()
    {
        Vector3 direction = Vector3.zero - transform.position;
        Instantiate(projectile, transform.position, quaternion.LookRotation(direction, Vector3.up));
    }
}