using UnityEngine;

public class RomperObstaculo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Verifica si el objeto que colisionó tiene la etiqueta "Pelota"
        if (collision.gameObject.CompareTag("Pelota"))
        {
            // Destruye este bloque
            Destroy(gameObject);
        }
    }
}
