using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enemyHealth : MonoBehaviour
{
    public int health = 1;

    public UnityEvent OnHealthEqualsZero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            OnHealthEqualsZero.Invoke();
        }
            
    }
}
