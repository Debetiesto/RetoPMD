using UnityEngine;

public class CloudFloatMovement : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float moveSpeed = 1.2f;                   // Velocidad base del movimiento
    public Vector2 directionChangeTimeRange = new Vector2(2f, 5f); // Rango aleatorio del tiempo entre cambios
    public float smoothTurnSpeed = 1.5f;             // Suavidad del giro
    public Vector2 areaLimits = new Vector2(10f, 5f); // Límites del área (X, Y)

    private Vector2 currentDirection;
    private Vector2 targetDirection;
    private float timer;
    private float currentChangeInterval;

    void Start()
    {
        // Asignar una dirección inicial y el primer intervalo aleatorio
        targetDirection = Random.insideUnitCircle.normalized;
        currentDirection = targetDirection;
        currentChangeInterval = Random.Range(directionChangeTimeRange.x, directionChangeTimeRange.y);
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Cambiar dirección al alcanzar el intervalo aleatorio
        if (timer >= currentChangeInterval)
        {
            targetDirection = Random.insideUnitCircle.normalized;
            timer = 0f;
            // Generar un nuevo intervalo aleatorio para el siguiente cambio
            currentChangeInterval = Random.Range(directionChangeTimeRange.x, directionChangeTimeRange.y);
        }

        // Suaviza la transición de dirección
        currentDirection = Vector2.Lerp(currentDirection, targetDirection, Time.deltaTime * smoothTurnSpeed);

        // Mueve la nube suavemente
        transform.Translate(currentDirection * moveSpeed * Time.deltaTime, Space.World);

        // Evita que salga de los límites
        CheckBounds();
    }

    void CheckBounds()
    {
        Vector3 pos = transform.position;

        // Rebote si alcanza los límites
        if (pos.x > areaLimits.x || pos.x < -areaLimits.x)
        {
            currentDirection.x = -currentDirection.x;
            targetDirection.x = -targetDirection.x;
            pos.x = Mathf.Clamp(pos.x, -areaLimits.x, areaLimits.x);
        }

        if (pos.y > areaLimits.y || pos.y < -areaLimits.y)
        {
            currentDirection.y = -currentDirection.y;
            targetDirection.y = -targetDirection.y;
            pos.y = Mathf.Clamp(pos.y, -areaLimits.y, areaLimits.y);
        }

        transform.position = pos;
    }
}
