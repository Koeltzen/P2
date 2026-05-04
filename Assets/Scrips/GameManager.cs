using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ClothingPanelData[] categories;
    
    public ClothingPanelData selectedCategory;
    private int currentQuestionIndex = 0;

    public GameObject panel;
    public Button[] replyButtons;
    


        void Start()
        {
            SelectCategory(0);
            
        }

        public void SelectCategory(int categoryIndex)
        {
            selectedCategory = categories[categoryIndex];
            currentQuestionIndex = 0;
            DisplayQuestion();
        }
    
    public void DisplayQuestion()
    {
       
        if (selectedCategory == null) return;

            var question = selectedCategory.questions[currentQuestionIndex];
            panel = question.Panel;

        for (int i = 0; i < replyButtons.Length; i++)
        {
            TMP_Text buttonText = replyButtons[i].GetComponentInChildren<TMP_Text>();
            buttonText.text = question.replies[i];
        }
        
    }

    public void OnReplySelected(int replyIndex)
    {
        var question = selectedCategory.questions[currentQuestionIndex];

        if (replyIndex == question.correctReplyIndex)
        {
            Debug.Log("Correct reply!");
            
        }
        else
        {
            Debug.Log("Wrong Reply!");
            
            SceneManager.LoadScene("Fired");
        }

        currentQuestionIndex++;

        if (currentQuestionIndex < selectedCategory.questions.Length)
        {
            DisplayQuestion();
        }
        else
        {
            SceneManager.LoadScene("Ending");
            Debug.Log("Quiz Finished");
        }
    }
}
