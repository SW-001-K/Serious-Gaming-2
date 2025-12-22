using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public string sceneLoad = "SampleScene";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
