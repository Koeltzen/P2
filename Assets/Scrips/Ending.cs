using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneLoader : MonoBehaviour
{
    public OutfitData data; // reference til dit script

    public void LoadEndScene()
    {
        float points = data.playerTotalPoints;

        if (points < 43f)
        {
            SceneManager.LoadScene("Ending1");
        }
        else if (points >= 43f && points <= 77f)
        {
            SceneManager.LoadScene("Ending2");
        }
        else
        {
            SceneManager.LoadScene("Ending3");
        }
    }
}