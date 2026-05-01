using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public class PaneldataArray
{
    public string questionText;
    public string[] replies;
    public GameObject Panel;
    public int correctReplyIndex;


    public void PanelOpener() {
        if (Panel != null) {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

}


[CreateAssetMenu(fileName = "New Category", menuName = "Quiz/Question Data")]
public class ClothingPanelData : ScriptableObject
{
    public string category;
    public PaneldataArray[] questions;
}
