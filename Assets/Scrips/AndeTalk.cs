using System.Collections;
using UnityEngine;

public class AndeTalk : MonoBehaviour
{
    private int currentChild = 0;

    public GameObject parentObject;

    public int childCount;
    

    public void ButtonClick()
    {
        Debug.Log("Bababooey");

        StartCoroutine(waiterTest());



    }



    IEnumerator waiterTest()
    {
        parentObject.transform.GetChild(currentChild).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        parentObject.transform.GetChild(currentChild).gameObject.SetActive(false);
        currentChild++;

        if (parentObject.transform.GetChild(currentChild))
            StartCoroutine(waiterTest());
    }

    void IterateThroughChildren()
    {
        childCount = parentObject.transform.childCount;




    }
}
