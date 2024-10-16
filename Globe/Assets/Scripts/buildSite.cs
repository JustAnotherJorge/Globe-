using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildSite : MonoBehaviour
{
    public int siteType;
    public int newResource = -1;

    [SerializeField] private GameObject[] weapons;

    [SerializeField] private Material[] siteMate;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if (siteType == 0)
            GetComponent<MeshRenderer>().material = siteMate[0];
        else if (siteType == 1)
            GetComponent<MeshRenderer>().material = siteMate[1];
        else if (siteType == 2)
            GetComponent<MeshRenderer>().material = siteMate[2];


        transform.LookAt(Vector3.zero);

        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject newWeaposn;

        if (siteType == 0 && newResource == 0) //shield
        {
            newWeaposn = Instantiate(weapons[0], transform.position, Quaternion.identity);
            newWeaposn.transform.SetParent(player.transform);
            Destroy(gameObject);
        }
        else if (siteType == 1 && newResource == 1) //gun
        {
            newWeaposn = Instantiate(weapons[1], transform.position, Quaternion.identity);
            newWeaposn.transform.SetParent(player.transform);
            Destroy(gameObject);
        }
        else if (siteType == 2 && newResource == 2) //heal
        {
            newWeaposn = Instantiate(weapons[2], transform.position, Quaternion.identity);
            newWeaposn.transform.SetParent(player.transform);
            Destroy(gameObject);
        }
    }
}
