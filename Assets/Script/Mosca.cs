using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosca : MonoBehaviour
{
    Vector3 initialPosition;
    public bool hasKey;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trampa")
        {
            transform.position = initialPosition;
        }
        if (collision.gameObject.name == "Llave")
        {
            hasKey = true;
            Destroy(collision.gameObject);
        
        if (collision.gameObject.name == "Llave")
        {
            Debug.Log("Tiene la llave");
        }
    }
}
