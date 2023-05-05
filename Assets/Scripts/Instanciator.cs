using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciator : MonoBehaviour
{
    public GameObject prefabProyectil;
    public Transform spawnPointTr;
    public string buttonString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(buttonString))
        {
            GameObject clon;
            clon = Instantiate(prefabProyectil, spawnPointTr.position, Quaternion.identity);
            Destroy(clon, 1);
        }
    }
}
