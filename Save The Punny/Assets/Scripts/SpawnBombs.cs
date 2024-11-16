using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject Bombs;
    public float MaxMinPosit;
    public float SpawnRate;

    void Start()
    {
        StartSpawn();   
    }
    void Spawn()
    {
        float X_Random = Random.Range(-MaxMinPosit, MaxMinPosit);
        Vector2 Spawn_Posit = new Vector2(X_Random, transform.position.y);
        Instantiate(Bombs, Spawn_Posit, Quaternion.identity);
    }
    void StartSpawn()
    {
        InvokeRepeating("Spawn", 1f, SpawnRate);
    }
    public void StopSpawn()
    {
        CancelInvoke("Spawn");
    }
}
