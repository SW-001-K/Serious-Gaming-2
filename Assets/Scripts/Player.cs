using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public FocusBar focusBar;

    void Awake()
    {
        Cursor.visible = false;              
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Start()
    {
        if (FocusManager.Instance != null && focusBar != null)
            focusBar.SetMaxFocus(FocusManager.Instance.maxFocus);
    }

    void Update()
    {
        if (FocusManager.Instance != null && focusBar != null)
            focusBar.SetFocus(FocusManager.Instance.currFocus);
    }
}
