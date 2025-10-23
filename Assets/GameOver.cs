using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public MenuManager menuManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pelota"))
        {
            // Destruye la pelota
            Destroy(other.gameObject);

            // Llamar al Game Over
            Terminado();
        }
    }

    void Terminado()
    {
        menuManager.MostrarGameOver();
        // Reinicia la escena actual después de 1.5 segundos
        Invoke("ReiniciarEscena", 1.5f);

    }

    void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
