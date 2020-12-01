using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController controlador;
    public static Color colorActual;
    public static int contadorCubos = 0;

    void Awake()
    {
        if (controlador == null) {
            controlador = this;
            DontDestroyOnLoad(this);
        } else if (controlador != this) {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        colorActual = Color.white; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rojo() {
        colorActual = Color.red;
    }

    public void verde() {
        colorActual = Color.green;
    }

    public void azul() {
        colorActual = Color.blue;
    }
    
}
