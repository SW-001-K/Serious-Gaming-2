using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    bool isGameActive;
    public GameOverScreen gameOverScreen;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

      void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        gameOverScreen =  FindFirstObjectByType<GameOverScreen>();
        isGameActive = true;

        if (gameOverScreen != null)
            gameOverScreen.Setup(false);
    }

    public void GameOver()
    {   
        Time.timeScale = 0f;
        
        if (!isGameActive) return;
        isGameActive = false;

        if (gameOverScreen != null)
            gameOverScreen.Setup(true);
    }

    public void Restart()
    {   
        Time.timeScale = 1f;
        if (gameOverScreen != null)
            gameOverScreen.Setup(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
