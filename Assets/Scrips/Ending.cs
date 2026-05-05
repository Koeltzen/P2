using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    private float GetTagCount(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        return objects.Length;
    }

    public void LoadEnding()
    {
        float shoes = GetTagCount("Shoes");
        float shirt = GetTagCount("Shirts");
        float thickshirt = GetTagCount("ThickShirts");
        float pants = GetTagCount("Pants");
        float jacket = GetTagCount("Jacket");
        float socks = GetTagCount("Socks");

        float totalFeet = shoes + socks;
        float totalUnder = pants;
        float totalOver = shirt + thickshirt + jacket;

        if (totalFeet < 12f || totalUnder < 12f || totalOver < 19f)
        {
            SceneManager.LoadScene("Ending1");
        }
        else if (
                (totalFeet >= 12f && totalFeet <= 23f) ||
                (totalUnder >= 12f && totalUnder <= 23f) ||
                (totalOver >= 19f && totalOver <= 42f)
        )
        {
            SceneManager.LoadScene("Ending2");
        }
        else
        {
            SceneManager.LoadScene("Ending3");
        }
    }
}