using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public static ButtonSound Instance;

    private AudioSource audioSource;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClick()
    {
        audioSource.Play();
    }
}