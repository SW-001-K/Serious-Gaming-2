using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net.Security;

public class GameOverScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Setup(bool show)
    {
          if (show)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

         else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
        gameObject.SetActive(show);
    }

    public void RestartButton()
    {
        GameManager.Instance.Restart();

    }

    public void MainMenuButton()
    {
   
       GameManager.Instance.MainMenu();
    }
}