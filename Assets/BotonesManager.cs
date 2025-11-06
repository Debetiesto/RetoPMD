using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesManager : MonoBehaviour
{
    public void reiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void volverMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void siguienteLvlLuis()
    {
        SceneManager.LoadScene("NivelLuis");
        Time.timeScale = 1.0f;
    }

    public void siguienteLvlUnai()
    {
        SceneManager.LoadScene("NivelUnai");
        Time.timeScale = 1.0f;
    }
}
