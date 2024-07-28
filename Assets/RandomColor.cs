using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomColor : MonoBehaviour
{

    [SerializeField] private GameObject bandera;
    [SerializeField] private Material color1;
    [SerializeField] private Material color2;
    [SerializeField] private Material color3;
    [SerializeField] private Material color4;
    [SerializeField] private Material color5;
    [SerializeField] private Material color6;
    [SerializeField] private Material colorCentral;
    private int numero;


    public void CambiarColor()
    {
        numero = Random.Range(0, 6);
        Material[] colores = { color1, color2, color3, color4, color5, color6, colorCentral};

        bandera.GetComponent<Renderer>().material = colores[numero];
    }


}
