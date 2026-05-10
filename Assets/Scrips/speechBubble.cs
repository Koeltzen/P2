using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class speechBubble : MonoBehaviour
{
    public GameObject[] bubble = new GameObject[1];
    public float timer, interval = 2f;

    public bool boobleActive = false;
    public void speechDone()
    {
        Debug.Log("start");
        timer += Time.deltaTime;
        if (timer <= interval)
        {
            boobleActive = true;
            Debug.Log("bubble active true!");
            for (int i = 0; i < 1; i++)
            {
                Debug.Log("forloop");
                if (i >= 0)
                {
                    bubble[i].SetActive(true);
                    Debug.Log("SetActive true!");
                }
                else  bubble[i].SetActive(false);
                Debug.Log("else");
            }
            timer = 0;
        }
    }
    public void Hide()
    {
        bubble[0].gameObject.SetActive(false);
    }
}
