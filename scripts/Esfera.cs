using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    private Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
        rd.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioColor() {
        rd.material.color = GameController.colorActual;
    }
}
