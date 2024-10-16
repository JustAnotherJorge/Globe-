using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidSpawning : MonoBehaviour
{
    [SerializeField] private GameObject astroid;

    [SerializeField] private float spawnRate = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 1, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        var spawnPo = Random.insideUnitCircle.normalized * 10;
        Instantiate(astroid, new Vector3(spawnPo.x, 0, spawnPo.y), Quaternion.identity);
    }
}
