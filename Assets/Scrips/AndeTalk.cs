using System.Collections;
using UnityEngine;

public class AndeTalk : MonoBehaviour
{
    private int currentChild = 0;

    public GameObject ParentObject;

    public int childCount;
    

    public void ButtonClick()
    {
        Debug.Log("Bababooey");

        StartCoroutine(waiterTest());



    }



    IEnumerator waiterTest()
    {
        ParentObject.transform.GetChild(currentChild).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        ParentObject.transform.GetChild(currentChild).gameObject.SetActive(false);
        currentChild++;

        if (ParentObject.transform.GetChild(currentChild))
            StartCoroutine(waiterTest());
        
    }

    void IterateThroughChildren()
    {
        childCount = ParentObject.transform.childCount;


    }
}
