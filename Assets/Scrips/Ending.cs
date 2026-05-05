using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneLoader : MonoBehaviour
{
    public OutfitData data;

    public void LoadEndScene()
    {
        float points = data.playerTotalPoints;

        if (points < 30f)
        {
            SceneManager.LoadScene("Ending1");
        }
        else if (points >= 30f && points <= 50f)
        {
            SceneManager.LoadScene("Ending2");
        }
        else
        {
            SceneManager.LoadScene("Ending3");
        }
    }
}