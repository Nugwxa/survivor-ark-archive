﻿using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 0.5f;
    public Transform[] spawnPoints;


	void Start ()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	
	void Spawn ()
    {
		if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
