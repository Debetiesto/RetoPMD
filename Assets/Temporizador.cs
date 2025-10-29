using TMPro;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    public float tiempoLimite = 60f; // segundos
    public TextMeshProUGUI textoTemporizador;   // arrastra un Text de la UI aquí
    private float tiempoRestante;
    public MenuManager menuManager;

    private bool tiempoCorriendo = false;

    void Start()
    {
        tiempoRestante = tiempoLimite;
        tiempoCorriendo = true;
    }

    void Update()
    {
        if (tiempoCorriendo)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante -= Time.deltaTime;
                ActualizarUI();
            }
            else
            {
                tiempoRestante = 0;
                tiempoCorriendo = false;
                FinDelTiempo();
            }
        }
    }

    void ActualizarUI()
    {
        // Convierte a minutos y segundos
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textoTemporizador.text = string.Format("TIEMPO:  {0:00}:{1:00}", minutos, segundos);
    }

    void FinDelTiempo()
    {
        menuManager.MostrarGameOver();
    }
}
