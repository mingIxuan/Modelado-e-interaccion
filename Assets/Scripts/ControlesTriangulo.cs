using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTriangulo : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.1f;
    float rotationSpeed = -4;
    public KeyCode teclaAvanzar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(speed, 0, 0);
        }

    }
}
