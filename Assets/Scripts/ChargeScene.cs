using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargeScene : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        int puntaje = 0;
        Debug.Log(gameObject.name);
        PlayerPrefs.SetString("nombre", gameObject.name);
        PlayerPrefs.SetInt("puntaje", puntaje + 1);
        SceneManager.LoadScene("Escena Final");
    }
}
