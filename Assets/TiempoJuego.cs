
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TiempoJuego : MonoBehaviour
{
    [SerializeField] private float tiempoMaximo;
    [SerializeField] private Slider slider;
    [SerializeField] private RandomColor randomColor;

    [SerializeField] private GameObject menuVictoria;
    [SerializeField] private GameObject hexagono1;
    [SerializeField] private GameObject hexagono2;
    [SerializeField] private GameObject hexagono3;
    [SerializeField] private GameObject hexagono4;
    [SerializeField] private GameObject hexagono5;
    [SerializeField] private GameObject hexagono6;
    [SerializeField] private GameObject hexagono7;
    [SerializeField] private GameObject bandera;

    
    private float tiempoActual;
    private int tiempoActual1;
    private bool tiempoActivado = false;
    private float indicador;
    private float indicador1;
    private float indicador2;

    private void Start()
    {
        ActivarTemporizador(); 
    }

    private void Update()
    {
        if(tiempoActivado)
        {            
            CambiarContador();
        }
        
    }

    private void CambiarContador()
    {
        tiempoActual -= Time.deltaTime;
        tiempoActual1 = (int)tiempoActual;


        if (tiempoActual1 <= indicador)
        {            
            randomColor.CambiarColor();
            indicador -= 4;
        }
        if (tiempoActual1 <= indicador1)
        {
            DesactivarSuelo();
            indicador1 -= 3;
            
        }
        if(tiempoActual1 <= indicador2)
        {
            ActivarSuelo();
            indicador2 -= 4;
        }

        if(tiempoActual > 0)
        {
            slider.value = tiempoActual;            
        }
        if(tiempoActual <= 0)
        {
            indicador = 5;
            menuVictoria.SetActive(true);
            CambiarTemporizador(false);
        }
        
    }

    private void DesactivarSuelo()
    {
        GameObject[] sueloSeguro = { hexagono1, hexagono2, hexagono3, hexagono4, hexagono5, hexagono6, hexagono7 };

        for (int i = 0; i < sueloSeguro.Length; i++)
        {
            if (sueloSeguro[i].GetComponent<Renderer>().sharedMaterial != bandera.GetComponent<Renderer>().sharedMaterial)
            {
                sueloSeguro[i].SetActive(false);
            }
        }
    }

    private void ActivarSuelo()
    {
        GameObject[] sueloSeguro = { hexagono1, hexagono2, hexagono3, hexagono4, hexagono5, hexagono6, hexagono7 };

        for (int i = 0; i < sueloSeguro.Length; i++)
        {
            sueloSeguro[i].SetActive(true);
        }
    }

    private void CambiarTemporizador(bool estado)
    {
        tiempoActivado = estado;   
    }

    public void ActivarTemporizador()
    {        
        indicador = tiempoMaximo;
        indicador1 = tiempoMaximo;
        indicador2 = tiempoMaximo;
        tiempoActual = tiempoMaximo;
        slider.maxValue = tiempoMaximo;
        CambiarTemporizador (true);
    }

    public void DesactivarTemporizador()
    {
        CambiarTemporizador(false);
    }
}
