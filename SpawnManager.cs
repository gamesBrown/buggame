using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject honey;
    public GameObject honeySpawner;
    private Vector3 honeySpawnerPos;
    float honeySpawnerOffsetX = 3f;
    float honeySpawnerOffsetZ = 5f;
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        honey = GameObject.Find("Honey");

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SpawnFromSpawner(honey, honeySpawner);
        }
    }
    private Vector3 GetRandomSpawnPosition(Vector3 spawnLocation, float spawnerOffsetX, float spawnerOffsetZ)
    {
        spawnLocation.x = Random.Range(honeySpawnerOffsetX, spawnLocation.x*2 -honeySpawnerOffsetX);
        spawnLocation.y = Random.Range(0, spawnLocation.y );
        spawnLocation.z = Random.Range(-spawnerOffsetZ, spawnerOffsetZ);
        
        return spawnLocation;
    }
    private void SpawnFromSpawner(GameObject spawnedObject, GameObject randomSpawnerPosition)
    {
        Vector3 spawnerMaxRange = randomSpawnerPosition.transform.position;
        
        Instantiate(spawnedObject, GetRandomSpawnPosition(spawnerMaxRange, honeySpawnerOffsetX, honeySpawnerOffsetZ), randomSpawnerPosition.transform.rotation);

    }
    
}
