using UnityEngine;

public class FocusManager : MonoBehaviour
{
    public static FocusManager Instance;

    public float maxFocus = 100f;
    public float currFocus;
    public float drainRate = 1f;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        currFocus = maxFocus;
    }

    void Update()
    {
        if (currFocus > 0)
        {
            currFocus -= drainRate* Time.deltaTime;
        }
        
        if (currFocus <= 0)
        {
            currFocus = 0;
            GameManager.Instance.GameOver();
        }
    }
}