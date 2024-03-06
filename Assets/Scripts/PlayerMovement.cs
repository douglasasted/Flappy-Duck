using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] float cooldown;

    float currentCooldown;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Cooldown
        currentCooldown -= Time.deltaTime;

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && currentCooldown <= 0)
        { 
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        
            currentCooldown = cooldown;
        }

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Clamp(rb.velocity.y / jumpForce, -90, 90) * 90);
    }
}