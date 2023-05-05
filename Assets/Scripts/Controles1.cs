using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
        }

    }
}
