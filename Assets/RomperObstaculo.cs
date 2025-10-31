using UnityEngine;

public class RomperObstaculo : MonoBehaviour
{
    public GameObject explosionPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Verifica si el objeto que colisionó tiene la etiqueta "Pelota"
        if (collision.gameObject.CompareTag("Pelota"))
        {
            // Crear explosión en la posición del coche
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

            ControlObstaculos.CocheDestruido();

            // Destruye este bloque
            Destroy(gameObject);
        }
    }
}
