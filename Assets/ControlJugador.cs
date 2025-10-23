using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    [Range(2.0f, 8.0f)]
    private float speed = 4.0f;
    private float minX, maxX;
    public float maxSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float halfPlayerWidth = transform.localScale.x / 2f;
        float screenHalfWidthInWorldUnits = Camera.main.orthographicSize * Screen.width / Screen.height;

        minX = -screenHalfWidthInWorldUnits + halfPlayerWidth;
        maxX = screenHalfWidthInWorldUnits - halfPlayerWidth;
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(horizontal * speed, 0);

        float clampedX = Mathf.Clamp(rb.position.x, minX, maxX);
        rb.position = new Vector2(clampedX, rb.position.y);


    }
}
