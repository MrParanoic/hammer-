using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nemu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
