using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
using TMPro; // Required for TextMeshPro UI elements

public class GameManager : MonoBehaviour
{   public static GameManager Instance;
    public GameOverScreen gameOverScreen; 
    public bool isGameActive; 
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        isGameActive = true;
        gameOverScreen.Setup(false);
    }


    public void GameOver()
    {
        isGameActive = false;
        gameOverScreen.Setup(true); 
 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 

    }
}
