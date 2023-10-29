using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject speedPowerupPrefab; 
    public GameObject healthPowerupPrefab; 

    private float spawnInterval = 30f;
    private float timeSinceLastSpawn = 0f;

    private void Start()
    {
        SpawnRandomPowerup();
    }

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnRandomPowerup();
            timeSinceLastSpawn = 0f;
        }
    }

    private void SpawnRandomPowerup()
    {
        GameObject powerupPrefab = Random.Range(0f, 1f) > 0.5f ? speedPowerupPrefab : healthPowerupPrefab;

        Vector3 spawnPosition = transform.position; 

        Instantiate(powerupPrefab, spawnPosition, Quaternion.identity);
    }
}

