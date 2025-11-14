using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [Header("Score Settings")]
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score (Test)")]
    private void IncreaseScoreTest()
    {
        addScore(1); // Adds +1 score when you click it in the Inspector
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        if (scoreText != null)
            scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (gameOverScreen != null)
            gameOverScreen.SetActive(true);
    }
}
