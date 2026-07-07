using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject gameOverPanel;

    public AudioSource buttonClickSound;
    private int score = 0;

    public void AddScore()
    {
        score++;

        scoreText.text = score.ToString();

        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        ButtonSound.Instance.PlayClick();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        ButtonSound.Instance.PlayClick();
        SceneManager.LoadScene("MainMenu");
    }
}