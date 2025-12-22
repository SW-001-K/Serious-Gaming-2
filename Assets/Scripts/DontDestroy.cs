using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }// Start is called once before the first execution of Update after the MonoBehaviour is created


}
