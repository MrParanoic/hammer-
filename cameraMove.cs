using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    Vector3 offset;
    
    void Awake()
    {
        offset = transform.position - target.transform.position;
    }
    void LateUpdate()
    {
        Vector3 posCamera = target.transform.position + offset;
        transform.position = posCamera;
        
    }
}
