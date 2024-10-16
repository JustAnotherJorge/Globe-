using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class resource : MonoBehaviour
{
    public int resourceType;

    [SerializeField] private float speed = 0.01f;

    [SerializeField] private GameObject buildSite;

    [SerializeField] private Material[] resourceMat;

    // Start is called before the first frame update
    void Start()
    {
        if (resourceType == 0)
            GetComponent<MeshRenderer>().material = resourceMat[0];
        else if (resourceType == 1)
            GetComponent<MeshRenderer>().material = resourceMat[1];
        else if (resourceType == 2)
            GetComponent<MeshRenderer>().material = resourceMat[2];

        transform.LookAt(Vector3.zero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject newBuildSite = Instantiate(buildSite, transform.position, Quaternion.identity);
            newBuildSite.transform.SetParent(other.transform);
            newBuildSite.GetComponent<buildSite>().siteType = resourceType;
            Destroy(gameObject);
        }
        else if (other.CompareTag("buildSite"))
        {
            other.GetComponent<buildSite>().newResource = resourceType;
            Destroy(gameObject);
        }
    }

}
