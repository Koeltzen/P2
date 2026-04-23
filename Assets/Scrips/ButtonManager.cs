using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    // Træk dine 4 billeder (GameObjects) ind i denne liste i Unity Inspector
    public GameObject[] billeder;

    // Denne funktion kaldes af dine knapper
    public void VisBillede(int billedeIndeks)
    {
        // 1. Gennemgå alle billeder i listen
        for (int i = 0; i < billeder.Length; i++)
        {
            // 2. Hvis nummeret passer med knappen -> TÆND. Ellers -> SLUK.
            if (i == billedeIndeks)
            {
                billeder[i].SetActive(true);
            }
            else if (i != billedeIndeks)
            {
                billeder[i].SetActive(false);
            }
            else
            {
                billeder[i].SetActive(true);
            }
        }
    }
}
