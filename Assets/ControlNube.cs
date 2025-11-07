using UnityEngine;

public class ControlNube : MonoBehaviour
{
    public static int cochesRestantes = 16; // Cantidad total de coches en el nivel
    public GameObject winCanvas;
    void Start()
    {
        // Asegurar que el contador inicie bien en cada escena
        cochesRestantes = 16;
        winCanvas.SetActive(false);
    }
    public static void NubeDestruida()
    {
        cochesRestantes--;

        if (cochesRestantes <= 0)
        {
            // Busca el CarManager y llama a Victory
            FindObjectOfType<ControlNube>().MostrarVictoria();
        }
    }
    void MostrarVictoria()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego opcional
    }
}
