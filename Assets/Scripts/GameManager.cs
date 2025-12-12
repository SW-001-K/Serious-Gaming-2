using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using TMPro; // Required for TextMeshPro UI elements

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; 
    public bool isGameActive; 

    void Start()
    {
        isGameActive = true;
        gameOverPanel.SetActive(false);
    }


    public void GameOver()
    {
        isGameActive = false;
        gameOverPanel.SetActive(true); 
        // Optional: Stop time when game over
        // Time.timeScale = 0f; 
    }

 
    public void RestartGame()
    {
        // Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        // If Time.timeScale was set to 0f, uncomment the next line:
        // Time.timeScale = 1f;
    }
}
