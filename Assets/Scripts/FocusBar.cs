using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic; 

public class FocusBar : MonoBehaviour
{   
    public Slider focusBarSlider;

    public void SetMaxFocus(float focus)
    {
        
        focusBarSlider.maxValue = focus;
        focusBarSlider.value = focus; 

    }

    public void SetFocus(float focus)
    {
        focusBarSlider.value = focus;

    }

}
