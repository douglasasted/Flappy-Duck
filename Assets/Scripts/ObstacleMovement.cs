using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float selfDestructTime;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);

        
        selfDestructTime -= Time.deltaTime;

        if (selfDestructTime <= 0)
            Destroy(gameObject);
    }
}
