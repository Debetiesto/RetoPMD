using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public void abrirJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
