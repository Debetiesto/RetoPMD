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

    public void siguienteLvl()
    {
        SceneManager.LoadScene("NivelUnai");
    }
}
