using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    [SerializeField] private float shotiInterval = 1;
    [SerializeField] private GameObject bullet;

    private AudioSource _myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        _myAudioSource = GetComponent<AudioSource>();
        transform.LookAt(2 * transform.position - Vector3.zero);

        InvokeRepeating("shoot", shotiInterval, shotiInterval);
    }

    void shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        _myAudioSource.Play();
    }
}
