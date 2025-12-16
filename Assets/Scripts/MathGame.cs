using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MathGame : MonoBehaviour
{
    public TMP_Text questionText;
    public TMP_InputField answerInput;
    public float drainRate = 1f;

    int correctAnswer;
    int difficulty = 1;
    int questionsSolved = 0;

    void Start()
    {
     
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

       
        answerInput.ActivateInputField();

        GenerateQuestion();
    }

    void GenerateQuestion()
    {
        int a, b;

        difficulty = 1 + (questionsSolved / 3);

        if (difficulty < 4)
        {
            a = Random.Range(1, 10);
            b = Random.Range(1, 10);
            correctAnswer = a + b;
            questionText.text = $"{a} + {b} = ?";
        }
        else if (difficulty < 7)
        {
            a = Random.Range(5, 20);
            b = Random.Range(1, a);
            bool subtract = Random.value > 0.5f;

            if (subtract)
            {
                correctAnswer = a - b;
                questionText.text = $"{a} - {b} = ?";
            }
            else
            {
                correctAnswer = a + b;
                questionText.text = $"{a} + {b} = ?";
            }
        }
        else if (difficulty < 11)
        {
            a = Random.Range(2, 12);
            b = Random.Range(2, 12);
            correctAnswer = a * b;
            questionText.text = $"{a} × {b} = ?";
        }
        else
        {
            int op = Random.Range(0, 3);
            a = Random.Range(10, 50);
            b = Random.Range(1, 20);

            switch (op)
            {
                case 0: 
                    correctAnswer = a + b;
                    questionText.text = $"{a} + {b} = ?";
                    break;

                case 1: 
                    correctAnswer = a - b;
                    questionText.text = $"{a} - {b} = ?";
                    break;

                case 2: 
                    correctAnswer = a * b;
                    questionText.text = $"{a} × {b} = ?";
                    break;
            }
        }

        Debug.Log($"Difficulty: {difficulty}, Question #{questionsSolved}");
    }

    //TO DO : discuss add focus w kenny
    public void CheckAnswer()
    {
        if (string.IsNullOrEmpty(answerInput.text))
            return;

        if (answerInput.text == correctAnswer.ToString())
        {
            Debug.Log("Correct!");
            questionsSolved++;

            if (FocusManager.Instance != null)
            {
                FocusManager.Instance.drainRate = -20f;
            }
            else
            {
                Debug.LogWarning("FocusManager.Instance is NULL");
            }
        }
        else
        {
            Debug.Log("Wrong!");

            if (FocusManager.Instance != null)
            {
                FocusManager.Instance.drainRate = 10f;
            }
        }

        answerInput.text = "";
        answerInput.ActivateInputField(); 
        GenerateQuestion();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            CheckAnswer();
        }

        // Exit math scene
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
