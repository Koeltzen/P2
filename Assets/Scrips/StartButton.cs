using UnityEngine;

public class StartButtonManager : MonoBehaviour
{
    public GameObject firstButton;
    public GameObject nextButton;
    public GameObject imageToShow;
    public GameObject imageToShow2;
    public GameObject imageToShow3;
    public GameObject andeTalkStart;

    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void ShowNext()
    {
        // Skjul første knap
        firstButton.SetActive(false);

        // Vis næste knap
        nextButton.SetActive(true);

        // Vis billede
        imageToShow.SetActive(true);

        imageToShow2.SetActive(true);

        imageToShow3.SetActive(true);

        andeTalkStart.SetActive(true);

        

        // Spil lyd
        audioSource.PlayOneShot(soundEffect);
    }
}