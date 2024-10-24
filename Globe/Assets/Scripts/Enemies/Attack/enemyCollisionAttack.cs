using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollisionAttack : MonoBehaviour
{
    [SerializeField] private int damagetoDeal = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<health>().dealDamage(damagetoDeal);
            Destroy(gameObject);
        }
    }
}
