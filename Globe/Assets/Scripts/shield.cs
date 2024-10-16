using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    [SerializeField] private int durabiltiy = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            other.GetComponent<astroid>().astroidHealth--;
            durabiltiy--;

            if (durabiltiy == 0)
                Destroy(gameObject);
        }
    }
}
