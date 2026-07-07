using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [Header("Sound Clips")]
    public AudioClip jumpSound;
    public AudioClip hitSound;
    public AudioClip scoreSound;
    public AudioClip buttonSound;

    private AudioSource audioSource;

    private void Awake()
    {
        // نتأكد أنه يوجد SoundManager واحد فقط
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // يبقى موجودًا عند الانتقال من Main Menu إلى Game Scene
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJump()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayHit()
    {
        audioSource.PlayOneShot(hitSound);
    }

    public void PlayScore()
    {
        audioSource.PlayOneShot(scoreSound);
    }

    public void PlayButton()
    {
        audioSource.PlayOneShot(buttonSound);
    }
}