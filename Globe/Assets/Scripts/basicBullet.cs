using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("killBullet", lifeTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            if (other.GetComponent<enemyHealth>() != null)
            {
                other.GetComponent<enemyHealth>().health--;
            }

            killBullet();
        }
    }

    void killBullet()
    {
        Destroy(gameObject);
    }
}
