using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject endPoint;
    private void OnTriggerStay(Collider other)
    {
            other.transform.position = Vector3.MoveTowards(other.transform.position, endPoint.transform.position, _speed * Time.deltaTime);
    }
}
