using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
{
    [SerializeField] private float speed = 10;

    private int astroidType;

    [SerializeField] private GameObject resource;

    public int astroidHealth = 1;

    public int damagetoDeal = 1;

    [SerializeField] private Material[] astroidMat;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Vector3.zero);
        astroidType = Random.Range(0, 3);

        if (astroidType == 0)
            GetComponent<MeshRenderer>().material = astroidMat[0];
        else if (astroidType == 1)
            GetComponent<MeshRenderer>().material = astroidMat[1];
        else if (astroidType == 2)
            GetComponent<MeshRenderer>().material = astroidMat[2];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);

        if (astroidHealth == 0)
            killAstroid();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<health>().dealDamage(damagetoDeal);
            Destroy(gameObject);
        }
    }

    void killAstroid()
    {
        GameObject newresource = Instantiate(resource, transform.position, Quaternion.identity);
        newresource.GetComponent<resource>().resourceType = astroidType;
        Destroy(gameObject);
    }
}
