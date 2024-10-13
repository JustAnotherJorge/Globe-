using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private float healTime = 5;
    [SerializeField] private int amountToHeal = 1;
    // Start is called before the first frame update
    void Start()
    {
     Invoke("doHeal", healTime);   
    }

    void doHeal()
    {
        GetComponentInParent<health>().heal(amountToHeal);
        Destroy(gameObject);
    }
}
