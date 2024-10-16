using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeCollisionManager : MonoBehaviour
{
    [SerializeField] private GameObject buildSite;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {      
            GetComponent<health>().dealDamage(other.GetComponent<astroid>().damagetoDeal);
            Destroy(other.gameObject);
        }
        else
        {
            if (other.CompareTag("resource"))
            {
                Instantiate(buildSite, transform.position, Quaternion.identity);
            }
        }
    }
}
