using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Cinemachine;
using System.Dynamic;

public class MainMenu : MonoBehaviour
{   
    [SerializeField] private CinemachineCamera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlayGame()
    {
        cam.Priority = 5;
        Invoke("LoadScene", 2);
        

    }

    void LoadScene()
    {
        
        SceneManager.LoadSceneAsync("SampleScene");

    }
    
}
