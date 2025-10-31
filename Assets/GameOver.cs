using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public MenuManager menuManager;
    public GameObject explosionPrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pelota"))
        {
            Debug.Log(" Explosión instanciada en " + other.transform.position);
            Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            // Destruye la pelota
            Destroy(other.gameObject);            

            // Llamar al Game Over
            Invoke(nameof(Terminado), 1.5f);
        }
    }

    void Terminado()
    {
        FindObjectOfType<Temporizador>().DetenerTiempo();
        menuManager.MostrarGameOver();
    }


}
