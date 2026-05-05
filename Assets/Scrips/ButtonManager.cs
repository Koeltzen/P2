using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] billeder;

    public void VisBillede(int billedeIndeks)
    {
        // Get the selected object
        GameObject valgtBillede = billeder[billedeIndeks];

        // Get its tag (category)
        string kategori = valgtBillede.tag;

        // Loop through all objects
        for (int i = 0; i < billeder.Length; i++)
        {
            // If same category, turn off other item
            if (billeder[i].tag == kategori)
            {
                billeder[i].SetActive(false);
            }
        }

        // Turn on the selected one
        valgtBillede.SetActive(true);
    }
}