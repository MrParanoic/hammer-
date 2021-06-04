using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.back * 7f * Time.deltaTime;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("qwe");
            Destroy(gameObject);
        }
    }
}
