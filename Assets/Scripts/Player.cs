using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public FocusBar focusBar;

    void Start()
    {
        focusBar.SetMaxFocus(FocusManager.Instance.maxFocus);
    }

    void Update()
    {
        focusBar.SetFocus(FocusManager.Instance.currFocus);
    }
}
