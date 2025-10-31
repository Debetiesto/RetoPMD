using UnityEngine;

public class AutoDestruir : MonoBehaviour
{
    public float tiempoVida = 0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
