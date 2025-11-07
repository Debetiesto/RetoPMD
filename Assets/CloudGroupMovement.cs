using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CloudGroupMovement : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float moveSpeed = 2f;
    private Vector2 moveDirection = Vector2.right;

    [Header("Tags de detección")]
    public string wallTag = "Wall";

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.gravityScale = 0;
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(wallTag))
        {
            ReverseDirection();
        }
    }

    private void ReverseDirection()
    {
        moveDirection *= -1f;
        Debug.Log("🌬️ Rebote con muro — Nueva dirección: " + moveDirection);
    }
}
