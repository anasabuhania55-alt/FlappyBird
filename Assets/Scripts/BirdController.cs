using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead) return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;

            SoundManager.Instance.PlayJump();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;

        isDead = true;

        SoundManager.Instance.PlayHit();

        FindFirstObjectByType<GameManager>().GameOver();
    }
}