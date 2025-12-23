using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net.Security;

public class OptionScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Setup(bool show)
    { 
        gameObject.SetActive(show);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
