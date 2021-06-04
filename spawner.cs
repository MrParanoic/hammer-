using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject Birch_prefab;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _Spawn;
    [SerializeField] private float secondsInvoke;
    [SerializeField] private float seconds;
    private void Start()
    {
        Invoke();
    }
    private void Invoke()
    {
        Invoke("Spawner", secondsInvoke);
    }
    private void Spawner()
    {
        if (Random.value > 0.5f)
        {
            Instantiate(Birch_prefab, _Spawn);
        }
        else
        {
            Instantiate(_prefab, _Spawn);
        }
        Invoke("Invoke", seconds);
    }

}
