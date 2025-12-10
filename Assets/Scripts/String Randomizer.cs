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

    // private void Update()
    // {
    //     pickRandomFromList();

    // }
    public void pickRandomFromList()
    {
        string[ ] messages = { 
        
        "Mitochondria is the powerhouse of the cell",
        "Pak Galih Dea is the best",
        "Serious game is a serious game",
        "A serious game or applied game is a game designed for a primary purpose other than pure entertainment.",
        "The platypus can lay eggs despite being a mammal",
        "Why am I programming?",
        "ADHD stands for attention deficit hyperactivity disorder",
        "Random string string string",
        "Is this the real life, or is this fantasy",
        "Akhirnya diimplement woi",
        "Look at whiteboard event done!",
        
        
        };

        string randomMessage = messages[Random.Range(0, messages.Length)];
        myTextField.text = randomMessage;

        

    }

}




