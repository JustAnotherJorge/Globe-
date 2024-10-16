using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private int hearts = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void dealDamage(int damageToDeal)
    {
        hearts -= damageToDeal;
        if ( hearts == 0)
            Destroy(gameObject);
    }

    public void heal(int amountToHeal)
    {
        hearts += amountToHeal;
    }
}
