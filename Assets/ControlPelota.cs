using UnityEngine;

public class ControlPelota : MonoBehaviour
{
    public float maxSpeed = 10f;
    private Rigidbody2D rb;
    public float minX, maxX, minY, maxY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float ballHalfWidth = transform.localScale.x / 2f;
        float ballHalfHeight = transform.localScale.y / 2f;
        float screenHalfWidthInWorldUnits = Camera.main.orthographicSize * Screen.width / Screen.height;
        float screenHalfHeightInWorldUnits = Camera.main.orthographicSize;

        minX = -screenHalfWidthInWorldUnits + ballHalfWidth;
        maxX = screenHalfWidthInWorldUnits - ballHalfWidth;
        minY = -screenHalfHeightInWorldUnits + ballHalfHeight;
        maxY = screenHalfHeightInWorldUnits - ballHalfHeight;
    }

    // Update is called once per frame
    void Update()
    {
        // Limitar la velocidad m�xima
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }

        // Limitar la posición dentro de los límites

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocity = rb.linearVelocity;

        // Forzar m�nimo rebote vertical para que no se quede horizontal
        if (Mathf.Abs(velocity.y) < 0.5f)
        {
            velocity.y = Mathf.Sign(velocity.y) * 0.5f;
            rb.linearVelocity = velocity;
        }
        if (collision.gameObject.CompareTag("Jugador"))
        {
            // Posición relativa de la pelota respecto al palo
            float x = (transform.position.x - collision.transform.position.x) / collision.collider.bounds.size.x;

            // Nueva dirección: cuanto más a la izquierda o derecha, más horizontal será la velocidad
            Vector2 direction = new Vector2(x, 1).normalized;

            // Mantener la velocidad constante (por ejemplo 8 unidades)
            rb.linearVelocity = direction * rb.linearVelocity.magnitude;
        }
    }
}
