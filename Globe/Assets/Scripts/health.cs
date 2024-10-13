using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private int hearts = 3;
    // Start is called before the first frame update
    void Start()
    {
        print(hearts);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            dealDamage();
        } 
    }

    private void dealDamage()
    {
        hearts--;
        if ( hearts == 0)
            Destroy(gameObject);

        print(hearts);

    }
}
