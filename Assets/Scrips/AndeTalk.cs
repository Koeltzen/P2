using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AndeTalk : MonoBehaviour
{
    private int currentChild = 0;

    public GameObject ParentObject;

    public int childCount;

    public speechBubble m_speechBubble;

    public CanvasGroup uiGroup;
    
    public void ButtonClick()
    {
        Debug.Log("Bababooey");
        m_speechBubble.speechDone();
        if(m_speechBubble.gameObject.activeInHierarchy)

            Time.timeScale = 0f;

            uiGroup.interactable = false;
            uiGroup.blocksRaycasts = false;

            StartCoroutine(waiterTest());
    }



  IEnumerator waiterTest()
    {
        while (currentChild < ParentObject.transform.childCount)
        {
            GameObject currentObject = ParentObject.transform.GetChild(currentChild).gameObject;

            currentObject.SetActive(true);

            yield return new WaitForSecondsRealtime(4);

            currentObject.SetActive(false);

            currentChild++;
        }

        Time.timeScale = 1f;

        uiGroup.interactable = true;
        uiGroup.blocksRaycasts = true;

        m_speechBubble.Hide();
        currentChild = 0;
    }

    
}
