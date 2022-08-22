using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoV1 : MonoBehaviour
{
    public bool IsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        if (!IsAlive)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        IsAlive = false;
        GetComponent < MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;


    }
}

