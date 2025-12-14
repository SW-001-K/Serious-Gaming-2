using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Setup(bool show)
    {
        gameObject.SetActive(show);
    }
}
