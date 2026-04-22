using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonController : MonoBehaviour
{
    public GameObject continueButton;

    void Start()
    {
        // Make sure it's hidden at the start
        continueButton.SetActive(false);
    }

    // This will be called when ANY button is pressed
    public void ShowContinueButton()
    {
        continueButton.SetActive(true);

        Debug.Log ("Button active");

        if(continueButton != true)
        {
            continueButton.SetActive(true);

            Debug.Log ("Button active again!!!");
        }

        else
        {
            return;

        }
    }


}