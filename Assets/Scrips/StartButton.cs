using UnityEngine;

public class StartButtonManager : MonoBehaviour
{
    public GameObject firstButton;
    public GameObject nextButton;
    public GameObject imageToShow;

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

        // Spil lyd
        audioSource.PlayOneShot(soundEffect);
    }
}