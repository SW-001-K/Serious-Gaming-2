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
    }

 
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
