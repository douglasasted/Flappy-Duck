using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);
    }
}
