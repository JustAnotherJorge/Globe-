using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidSpawning : MonoBehaviour
{
    [SerializeField] private float spawnRate = 3;

    [SerializeField] private GameObject[] enemies;

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
        int i = Random.Range(0, enemies.Length);
        print(i);

        var spawnPo = Random.insideUnitCircle.normalized * 10;
        Instantiate(enemies[i], new Vector3(spawnPo.x, 0, spawnPo.y), Quaternion.identity);
    }
}
