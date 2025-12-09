using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    public float maxFocus = 100;
    public float currFocus;

    public FocusBar focusBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currFocus = maxFocus; 
        focusBar.SetMaxFocus(maxFocus);

    }

    // Update is called once per frame
    void Update()
    {
            LoseFocus();
    }

    void LoseFocus()
    {
        if (currFocus > 0){
            currFocus -= Time.deltaTime;
            focusBar.SetFocus(currFocus);
        }
       
    }
}
