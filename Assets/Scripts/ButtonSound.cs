using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public static ButtonSound Instance;

    public AudioSource audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void PlayClick()
    {
        audioSource.Play();
    }
}