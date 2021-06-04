using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private Rigidbody first;
    [SerializeField] private Rigidbody second;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "blade")
        {
            first.AddForce(Vector3.back * force);
            second.AddForce(Vector3.forward * force);
        }
    }
}
