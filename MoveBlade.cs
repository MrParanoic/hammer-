using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlade : MonoBehaviour
{
    public Animation _animate;
    private void Start()
    {
        _animate = GetComponent<Animation>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _animate.Play("AxeMove");
        }
    }

}
