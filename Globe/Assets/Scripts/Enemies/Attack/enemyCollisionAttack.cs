using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEditor;

public class enemyCollisionAttack : MonoBehaviour
{
    [SerializeField] private int damagetoDeal = 1;

    [SerializeField] private string[] targetTag = new string[] {"Player"};


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
        if (other.CompareTag(targetTag[0]))
        {
            other.GetComponent<health>().dealDamage(damagetoDeal);
            Destroy(gameObject);
        }
        else if(targetTag.Length > 1)
        {
            if (other.CompareTag(targetTag[1]))
                Destroy(gameObject);
        }
    }
}
