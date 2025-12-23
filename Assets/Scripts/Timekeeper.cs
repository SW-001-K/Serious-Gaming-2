using UnityEngine;

public class Timekeeper : MonoBehaviour
{
    public static Timekeeper Instance;

    [SerializeField] public float startTime;
    public float remainingTime;
    public bool isRunning = true;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        
        ResetTimer();
        remainingTime = startTime;

    }

    void Update()
    {
        if (!isRunning) return;

        remainingTime -= Time.deltaTime;

        if (remainingTime < 0)
        {
            GameManager.Instance.GameOver();
        }
    
    }

    public void ResetTimer()
    {
        remainingTime = startTime;

    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void StartTimer()
    {
        isRunning = true;
    }
}
