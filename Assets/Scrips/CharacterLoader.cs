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
        //reset all 
        underwearBoxer.SetActive(false);
        underwearPanties.SetActive(false);
        underwearBra.SetActive(false);
        underwearTop.SetActive(false);
        underwearTanktop.SetActive(false);
        sockNormal.SetActive(false);
        sockShort.SetActive(false);
        socksLong.SetActive(false);
        socksTights.SetActive(false);
        shirtLong.SetActive(false);
        shirtLongpolo.SetActive(false);
        shirtPolo.SetActive(false);
        shirtTshirt.SetActive(false);
        pantsJeans.SetActive(false);
        pantsJeans2.SetActive(false);
        pantsSkirt.SetActive(false);
        pantsTrack.SetActive(false);
        pantsTrouser.SetActive(false);
        shoeHikingboot.SetActive(false);
        shoeRubberboot.SetActive(false);
        shoeSandal.SetActive(false);
        shoeSneaker.SetActive(false);
        jacketCahartt.SetActive(false);
        jacketDenim.SetActive(false);
        jacketPuffer.SetActive(false);
        jacketPuffervest.SetActive(false);
        thickshirtAnorak.SetActive(false);
        thickshirtCardigan.SetActive(false);
        thickshirtHoodie.SetActive(false);
        thickshirtJersey.SetActive(false);

    // Apply selected 
        if (clothingData.underwearType== "Boxer")
            underwearBoxer.SetActive(true);
            

        else if (clothingData.underwearType== "Panties")
            underwearPanties.SetActive(true);

        else if (clothingData.underwearTopsType== "TopPlacement")
            underwearTop.SetActive(true);

        else if (clothingData.underwearTopsType== "TankTopPlacement")
            underwearTanktop.SetActive(true);

        else if (clothingData.underwearTopsType== "BraPlacement")
            underwearBra.SetActive(true);

        else if (clothingData.sockType== "SocksPlacement")
            sockNormal.SetActive(true);

        else if (clothingData.sockType== "SocksPlacement")
            sockNormal.SetActive(true);
    }

}
