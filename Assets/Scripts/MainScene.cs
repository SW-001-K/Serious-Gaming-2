using UnityEngine;

public class MainScene : MonoBehaviour
{
    public float drainRate = 1f;// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FocusManager.Instance.drainRate = drainRate;
    }
}
