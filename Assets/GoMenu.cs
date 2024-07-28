using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GoMenu : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }


}
