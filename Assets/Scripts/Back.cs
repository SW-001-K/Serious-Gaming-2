using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("SampleScene");
        }
    }
}
