using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SueloDerrota : MonoBehaviour
{
    [SerializeField] private TiempoJuego tiempoJuego;
    private void OnTriggerEnter(Collider suelo)
    {
        if (suelo.CompareTag("Player"))
        {
            tiempoJuego.DesactivarTemporizador();
            suelo.GetComponent<VidaMario>().Daño(1);
        }
    }
}
