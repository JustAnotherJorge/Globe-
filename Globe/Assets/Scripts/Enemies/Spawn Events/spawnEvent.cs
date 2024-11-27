using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spawn Event", menuName = "spawnEvent")]
public class spawnEvent : ScriptableObject
{
    public GameObject[] enemiesToSpawn;
    public float spawnDelay;
    public bool multiPosition;


}
