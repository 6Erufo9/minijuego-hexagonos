using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuDerrota;
    private VidaMario vidaJugador;

    private void Start()
    {
        vidaJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<VidaMario>();
        vidaJugador.DerrotaJugador += ActivarDerrota;
    }

    private void ActivarDerrota(object sender, EventArgs e)
    {
        menuDerrota.SetActive(true);
    }    
    
    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    
}
