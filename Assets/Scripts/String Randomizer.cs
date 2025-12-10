using UnityEngine;
using TMPro;

public class StringRandomizer : MonoBehaviour
{
 // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text myTextField;

    private void Start()
    {
        pickRandomFromList();

    }
    public void pickRandomFromList()
    {
        string[ ] messages = { 
        
        "Mitochondria is the powerhouse of the cell",
        "Pak Galih Dea is the best",
        "Serious game is a serious game",
        "Awesome!",
        
        
        };

        string randomMessage = messages[Random.Range(0, messages.Length)];
        myTextField.text = randomMessage;

        

    }

}




