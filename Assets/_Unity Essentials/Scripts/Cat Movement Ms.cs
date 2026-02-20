using UnityEngine;

public class CatMovementMs : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if (movement.magnitude > 0.1f)
        {
            rb.linearVelocity = movement * speed;

            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
            audioSource.Stop();
        }
    }
}
