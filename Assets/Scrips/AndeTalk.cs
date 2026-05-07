using System.Collections;
using UnityEngine;

public class AndeTalk : MonoBehaviour
{
    private int currentChild = 0;

    public GameObject ParentObject;

    public int childCount;

    public speechBubble m_speechBubble;
    
    public void ButtonClick()
    {
        Debug.Log("Bababooey");
        m_speechBubble.speechDone();
        if(m_speechBubble.gameObject.activeInHierarchy)
            StartCoroutine(waiterTest());
    }



    IEnumerator waiterTest()
    {

        ParentObject.transform.GetChild(currentChild).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        ParentObject.transform.GetChild(currentChild).gameObject.SetActive(false);
        currentChild++;
        Transform currentChildObject = null;
        try
        {
            currentChildObject = ParentObject.transform.GetChild(currentChild);
        }
        catch (System.Exception)
        {
            
        }
        if (currentChildObject is not null)
            StartCoroutine(waiterTest());
        else
        {
            m_speechBubble.Hide();
        }
    }

    
}
