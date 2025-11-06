using Unity.VisualScripting;
using UnityEngine;

public class ControlObstaculosContainers : MonoBehaviour
{
    public static int containersRestantes = 16;
    public GameObject winCanvas;

    void Start()
    {
        // Asegurar que el contador inicie bien en cada escena
        containersRestantes = 16;
        winCanvas.SetActive(false);
    }
    public static void ContainerDestruido()
    {
        containersRestantes--;

        if (containersRestantes <= 0)
        {
            // Busca el CarManager y llama a Victory
            FindObjectOfType<ControlObstaculosContainers>().MostrarVictoria();
        }
    }
    void MostrarVictoria()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0f; // Pausa el juego opcional
    }
}
