using UnityEngine;
using UnityEngine.UI;

public class CharacterLoader : MonoBehaviour
{
    public CharacterClothing clothingData;

    public GameObject underwearBoxer;
    public GameObject underwearPanties;
    public GameObject underwearTop;
    public GameObject underwearTanktop;
    public GameObject underwearBra;
    public GameObject sockNormal;
    public GameObject sockShort;
    public GameObject socksLong;
    public GameObject socksTights;
    public GameObject pantsJeans;
    public GameObject pantsJeans2;
    public GameObject pantsTrack;
    public GameObject pantsSkirt;
    public GameObject pantsTrouser;
    public GameObject shirtPolo;
    public GameObject shirtLong;
    public GameObject shirtTshirt;
    public GameObject shirtLongpolo;
    public GameObject thickshirtCardigan;
    public GameObject thickshirtHoodie;
    public GameObject thickshirtAnorak;
    public GameObject thickshirtJersey;
    public GameObject shoeSneaker;
    public GameObject shoeHikingboot;
    public GameObject shoeRubberboot;
    public GameObject shoeSandal;
    public GameObject jacketPuffer;
    public GameObject jacketDenim;
    public GameObject jacketCahartt;
    public GameObject jacketPuffervest;

    
    void Start()
    {
        ApplyClothes();
        DontDestroyOnLoad(gameObject);
    }

    void ApplyClothes()
    {
        //reset all shoes
        underwearBoxer.SetActive(false);
        underwearPanties.SetActive(false);

    // Apply selected shoes
        if (clothingData.underwearType== "Boxer")
            underwearBoxer.SetActive(true);

        if (clothingData.underwearType== "Panties")
            underwearPanties.SetActive(true);
    }

}
