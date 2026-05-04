using UnityEngine;
using System.Collections.Generic;
public class OutfitData: MonoBehaviour
{
    public Dictionary<string, float> values = new Dictionary<string, float>()
    {
        {"sockNormal", 2f},
        {"sockShort", 2f},
        {"socksLong", 3f},
        {"socksTights", 5f},
        {"pantsJeans", 12f},
        {"pantsJeans2", 7f},
        {"pantsTrack", 12f},
        {"pantsSkirt", 12f},
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
        {"mitten", 10f},
        {"scarf", 10f},
        {"beanie", 12f}
    };

    float playerTotalPoints = 0;

    public void AddPoints(string itemName)
    {
        if (values.ContainsKey(itemName))
        {
            playerTotalPoints += values[itemName];
            Debug.Log("Your score:" + playerTotalPoints); 
        }
    }
}
