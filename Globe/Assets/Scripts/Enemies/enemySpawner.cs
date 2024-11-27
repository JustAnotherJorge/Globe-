using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private float baseSpawnRate; //The base speed enemies will be spawned at.
    [SerializeField] private float baseSpawnRateModifer; //The modifer that will incree spawnrate overtime;

    public Vector2 spawnPosition;

    [SerializeField] private float spawnRadius = 5;

    [SerializeField] private spawnEvent[] enemySpawnEvents;


    // Start is called before the first frame update
    void Start()
    {
        spawnCoolDown();
    }

    void spawnCoolDown()
    {
        Invoke("spawnManagment", baseSpawnRate);
    }

    void spawnManagment()
    {
        spawnPosition = Random.insideUnitCircle.normalized * spawnRadius;
        
        
        int spawnEventIndex = Random.Range(0, enemySpawnEvents.Length);
        int numberOfEnemiesToSpawn = enemySpawnEvents[spawnEventIndex].enemiesToSpawn.Length;
        print (numberOfEnemiesToSpawn);
        int currantEnemyIndex = 0;
        StartCoroutine(spawnEnemy(numberOfEnemiesToSpawn, currantEnemyIndex, spawnEventIndex));
    }

    IEnumerator spawnEnemy(int numberOfEnemiesToSpawn, int currantEnemyIndex, int spawnEventIndex)
    {
        if (enemySpawnEvents[spawnEventIndex].multiPosition == true)
            spawnPosition = Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemySpawnEvents[spawnEventIndex].enemiesToSpawn[currantEnemyIndex], spawnPosition, Quaternion.identity);
        currantEnemyIndex++;

        if (currantEnemyIndex < numberOfEnemiesToSpawn)
        {
            yield return new WaitForSecondsRealtime(enemySpawnEvents[spawnEventIndex].spawnDelay);
            StartCoroutine(spawnEnemy(numberOfEnemiesToSpawn, currantEnemyIndex, spawnEventIndex));
        }
        else
        {
            spawnCoolDown();
        }

        
    }


    // Update is called once per frame
    void Update()
    {
        //gets a raondom postion on a circle around the player
        //selects a spawn event from a list
        //runs spawn event from the selectioned postions location

        //Needs to wait a certain amount of time between spawn events
        //get new postion a certain mimumum distance away from the last spawn event
        //scale spawn events with time.
    }
}
