using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerPrefabsMenu : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject prefab1;
    [SerializeField] private float secondForCallSpawn;
    [SerializeField] private float secondForCallStart;
    void Start()
    {
        Invoke("Spawn", secondForCallSpawn);
    }
    private void Spawn()
    {
        if (Random.value>0.5f)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(prefab1, transform.position, Quaternion.identity);
        }
        
        Invoke("Start", secondForCallStart);
    }
    
    
}
