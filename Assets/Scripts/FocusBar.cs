using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic; 

public class FocusBar : MonoBehaviour
{   
    public Slider focusBarSlider;
    public int maxFocus;
    public int currFocus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currFocus = maxFocus; 
        focusBarSlider.value = currFocus;
        focusBarSlider.maxValue = maxFocus; 
    }

    // Update is called once per frame
    void Update()
    {
        
        focusBarSlider.value = currFocus;
        focusBarSlider.maxValue = maxFocus; 
        


    }
}
