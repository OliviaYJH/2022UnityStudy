﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] hazards;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float minTimeBetweenSpawns;
    public float decrease;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            if(timeBtwSpawns <= 0){
            // SPAWN HAZARD
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

            // Spawn random hazard at random spawn point
            Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);

            if(startTimeBtwSpawns > minTimeBetweenSpawns){
                startTimeBtwSpawns -= decrease;
            }

            timeBtwSpawns = startTimeBtwSpawns;
            }else{
                timeBtwSpawns -= Time.deltaTime;
            }
        }
        
    }
}
