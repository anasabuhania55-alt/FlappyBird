using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(PlayButtonSound);
    }

    private void PlayButtonSound()
    {
        SoundManager.Instance.PlayButton();
    }
}