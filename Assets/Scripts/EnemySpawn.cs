using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;
public class EnemySpawn : MonoBehaviour
{
    [SerializeField] float spawnRate;
    [SerializeField] GameObject enemyToSpawn;
    float timer = 0;

    void Start()
    {

    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawn();
            timer = 0;
        }
    }

    void Spawn()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
    }
}
