using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Cinemachine;
using System.Dynamic;

public class MainMenu : MonoBehaviour
{   
    [SerializeField] private CinemachineCamera cam;
    public OptionScreen optionScreen;
    public AboutScreen aboutScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
    if (optionScreen != null)
        optionScreen.Setup(false);

    if (aboutScreen != null)
        aboutScreen.Setup(false);
    }

    public void PlayGame()
    {   
        cam.Priority = 5;
        Invoke("LoadScene", 2);
        
    }

    void LoadScene()
    {   
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void Credit()
    {
        optionScreen.Setup(true);
    }
    
    public void About()
    {
        aboutScreen.Setup(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
