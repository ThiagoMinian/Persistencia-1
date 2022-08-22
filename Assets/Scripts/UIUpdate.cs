using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour
{
    public Text text;
    public Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        text.text = PlayerPrefs.GetString("nombre");
        puntaje.text = PlayerPrefs.GetInt("puntaje").ToString();


    }

    void Update()
    {
        
    }
}
