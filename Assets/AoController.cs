using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AoController : MonoBehaviour
{
    float rotate = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            rotate = 10;
        }
        transform.Rotate(0, 0, rotate);
        rotate *= 0.96f;
    }

    public float Rotate => rotate;
}
