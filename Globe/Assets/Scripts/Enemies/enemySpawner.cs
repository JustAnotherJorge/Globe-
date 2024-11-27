using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private float baseSpawnRate; //The base speed enemies will be spawned at.
    [SerializeField] private float baseSpawnRateModifer; //The modifer that will incree spawnrate overtime;

    // Start is called before the first frame update
    void Start()
    {
        
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
