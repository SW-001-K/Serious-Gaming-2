@ -3,26 + 3,44 @@ using UnityEngine.SceneManagement; // Required for scene management
using TMPro; // Required for TextMeshPro UI elements

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel; 
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
        gameOverPanel.SetActive(false);
        gameOverScreen.Setup(false);
    }


    public void GameOver()
    {
        isGameActive = false;
<<<<<<< HEAD
        gameOverPanel.SetActive(true);
=======
        gameOverScreen.Setup(true); 
 
>>>>>>> Kenny-workspace
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

<<<<<<< HEAD
=======
>>>>>>> Kenny-workspace
    }
}