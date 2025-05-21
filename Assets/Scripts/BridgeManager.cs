using System.Collections.Generic;
using UnityEngine;
using TMPro;  

public class BridgeManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject questionUI;
    public TMP_Text questionText;
    public TMP_Text feedbackText;
    public TMP_InputField answerInput;
    public GameObject[] bridgeStones;

    [Header("Questions")]
    public List<QuestionData> questions = new List<QuestionData>();

    private int currentQuestionIndex = 0;

    void Start()
    {
      
            questionUI.SetActive(true);

          
            foreach (GameObject stone in bridgeStones)
            {
                stone.SetActive(false);
            }

            ShowNextQuestion();
            Debug.Log("BridgeStones Start called");
          
        
       
    }

    public void ShowNextQuestion()
    {
        if (currentQuestionIndex < questions.Count)
        {
            QuestionData currentQuestion = questions[currentQuestionIndex];
            questionText.text = currentQuestion.question;
            answerInput.text = "";
            feedbackText.text = "";
        }
        else
        {
            questionText.text = "The bridge is completed!";
            feedbackText.text = "You can cross over!";
            questionUI.SetActive(false);
        }
    }

    public void SubmitAnswer()
    {
        if (currentQuestionIndex >= questions.Count) return;

        QuestionData currentQuestion = questions[currentQuestionIndex];
        string playerAnswer = answerInput.text.Trim();

        if (playerAnswer.Equals(currentQuestion.correctAnswer, System.StringComparison.OrdinalIgnoreCase))
        {
            feedbackText.text = "TRUE!";
            Debug.Log($"Taþ açýlýyor: index {currentQuestionIndex}");
            bridgeStones[currentQuestionIndex].SetActive(true);
            currentQuestionIndex++;
            Invoke(nameof(ShowNextQuestion), 1.2f);
        }
        else
        {
            feedbackText.text = "Wrong! Try again.";
        }
    }

}

