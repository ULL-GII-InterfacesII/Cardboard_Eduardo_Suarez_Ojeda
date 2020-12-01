using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recolectado() {
        GameController.contadorCubos += 1;
        Destroy(gameObject);
        Text mytxt = GameObject.Find("/Canvas2/TextCubos").GetComponent<Text>();
        mytxt.text = "Cubos recogidos = " + GameController.contadorCubos.ToString();
    }
}

