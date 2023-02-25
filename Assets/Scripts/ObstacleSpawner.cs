using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Obstacle obstacle;
    [SerializeField] private Transform platform;
    [SerializeField] float spawnInterval = 1f;

    private float _nextSpawnTime;

    private void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            
            float randomX = Random.Range(-10f, 10f);

            
           var spawnedObject = Instantiate(obstacle, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

            spawnedObject.transform.parent = platform;

            _nextSpawnTime = Time.time + spawnInterval;
        }
    }
}
