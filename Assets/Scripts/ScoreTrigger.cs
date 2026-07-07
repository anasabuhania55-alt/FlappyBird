using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool scored = false;
    private AudioSource scoreSound;

    void Start()
    {
        scoreSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (scored) return;

        if (other.CompareTag("Player"))
        {
            scored = true;

            FindFirstObjectByType<GameManager>().AddScore();

            scoreSound.Play();
        }
    }
}