using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource pointSFX;
    public AudioSource dieSFX;

    public void AddScore(int scoreToAdd)
    {
        pointSFX.Play();
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        dieSFX.Play();
        GameOverScreen.SetActive(true);
    }
}
