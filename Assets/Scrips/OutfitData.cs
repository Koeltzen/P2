using UnityEngine;
using System.Collections.Generic;
using System.Drawing;
public class OutfitData : MonoBehaviour
{
    private Dictionary<string, float> values = new Dictionary<string, float>()
    {
        {"sockNormal", 2f},
        {"sockShort", 2f},
        {"socksLong", 3f},
        {"socksTights", 5f},
        {"pantsJeans", 12f},
        {"pantsJeans2", 7f},
        {"pantsTrack", 12f},
        {"pantsSkirt", 7f},
        {"pantsTrouser",7f},
        {"shirtPolo", 7f},
        {"shirtLong", 10f},
        {"shirtTshirt", 7f},
        {"shirtLongpolo", 10f},
        {"thickshirtCardigan", 15f},
        {"thickshirtHoodie", 20f},
        {"thickshirtAnorak", 20f},
        {"thickshirtJersey", 20f},
        {"shoeSneaker", 10f},
        {"shoeHikingboot", 20f},
        {"shoeRubberboot", 10f},
        {"shoeSandal", 2f},
        {"jacketPuffer", 25f},
        {"jacketDenim", 12f},
        {"jacketCahartt", 12f},
        {"jacketPuffervest", 10f},
        {"jacketRain", 12f},
        {"mitten", 10f},
        {"scarf", 10f},
        {"beanie", 12f},
        {"none1", 0f},
        {"none2", 0f},
        {"none3", 0f},
    };

    private HashSet<string> clickedButton = new HashSet<string>();
    private string currentChoice = "";

    public float playerTotalPoints = 0f;

    public void AddPoints(string itemName)
    {
        if (!values.ContainsKey(itemName)) return;


        //checks if you already have points
        if (clickedButton.Contains(itemName)) return;
        

        currentChoice = itemName;
        Debug.Log("Chose" + itemName + "(" + values[itemName] +  "point)");
        
    }
    public void ConfirmChoice()
    {
        if (string.IsNullOrEmpty(currentChoice)) return;

        float point = values[currentChoice];
        playerTotalPoints += point;




        Debug.Log("Your score:" + playerTotalPoints); 
        currentChoice = ""; //reset
    }
}
