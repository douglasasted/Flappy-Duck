using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float selfDestructTime;

    bool addedScore;

    Rigidbody2D rb;

    ScoreManager scoreManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        scoreManager = ScoreManager.Instance;
    }

    void Update()
    {
        rb.velocity = new Vector2(-speed, 0);


        selfDestructTime -= Time.deltaTime;

        if (selfDestructTime <= 0)
            Destroy(gameObject);

        if (transform.position.x < 0 && !addedScore)
        {
            scoreManager.AddScore();

            addedScore = true;
        }
    }
}
