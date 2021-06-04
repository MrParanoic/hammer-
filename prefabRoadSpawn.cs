using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabRoadSpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject Road;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            Instantiate(Road, spawnPoint);
        }
    }
}
