using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  //  public GameObject panelMenu;
    public GameObject textoGameOver;

    void Start()
    {
        // Mostrar el menú al inicio
       // panelMenu.SetActive(true);
        textoGameOver.SetActive(false);

        // Pausar el juego hasta que el jugador presione "Jugar"
        Time.timeScale = 0;
    }

    /*public void IniciarJuego()
    {
        panelMenu.SetActive(false);
        Time.timeScale = 1; // Reanudar el juego
    }*/

    public void MostrarGameOver()
    {
        textoGameOver.SetActive(true);

        // Pausar el juego
        Time.timeScale = 0;

        // O reiniciar la escena tras unos segundos (opcional)
        // Invoke("ReiniciarEscena", 2f);
    }

    public void ReiniciarEscena()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
