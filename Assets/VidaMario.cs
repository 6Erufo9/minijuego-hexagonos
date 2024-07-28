using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaMario : MonoBehaviour
{
    private int vida = 1;
    public event EventHandler DerrotaJugador;

    public void Daño(int cantidadDaño)
    {

        vida -= cantidadDaño;

        if(vida <= 0)
        {
            Destroy(gameObject);
            DerrotaJugador.Invoke(this, EventArgs.Empty);
        }
    }    
}
