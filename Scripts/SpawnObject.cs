using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject SpawnPrefab;
    public float SpawnTime;
    public float SpawnStart;

    void Start()
    {
        InvokeRepeating("SpawnBlock", SpawnStart, SpawnTime);
    }
    void SpawnBlock()
    {
        GameObject block = Instantiate(SpawnPrefab, transform.position, transform.rotation) as GameObject;
    }
}