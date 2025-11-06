using UnityEngine;

public class ControlObstaculosCoches : MonoBehaviour
{
    public static int cochesRestantes = 18; // Cantidad total de coches en el nivel
    public GameObject winCanvas;
    void Start()
    {
        // Asegurar que el contador inicie bien en cada escena
        cochesRestantes = 18;
        winCanvas.SetActive(false);
    }
    public static void CocheDestruido()
    {
        cochesRestantes--;

        if (cochesRestantes <= 0)
        {
            // Busca el CarManager y llama a Victory
            FindObjectOfType<ControlObstaculosCoches>().MostrarVictoria();
        }
    }

    void MostrarVictoria()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego opcional
    }
}
