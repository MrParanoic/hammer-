using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject prefabWall;
    [SerializeField] private Transform SpawnerTransform;
    [SerializeField] private float secondCallSpawn;
    [SerializeField] private float secondCallStart;

    private void Start()
    {
        Invoke("spawn", secondCallSpawn);
    }
    private void spawn()
    {

        Instantiate(prefabWall,SpawnerTransform);
        Invoke("spawn", secondCallStart);

    }
}
