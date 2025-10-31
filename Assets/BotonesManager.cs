using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesManager : MonoBehaviour
{
    public void reiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
