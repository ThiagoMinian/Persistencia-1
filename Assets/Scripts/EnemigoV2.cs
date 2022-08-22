using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoV2 : MonoBehaviour
{
    public EnemigoData data;
    // Start is called before the first frame update
    void Start()
    {
        if (!data.IsAlive)
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
        data.IsAlive = false;
        GetComponent < MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
     }
}
