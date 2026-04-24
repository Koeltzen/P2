using UnityEngine;

public class DressUpManager : MonoBehaviour
{
    public CharacterClothing clothingData;

    void Awake()
    {
        DressUp();
    }

    public void SelectShoes(string shoeName)
    {
        clothingData.shoeType= shoeName;

    }

    public void SelectUnderwear(string underwearName)
    {
        clothingData.underwearType= underwearName;

    }

        public void SelectUnderwearTop(string underwearTopName)
    {
        clothingData.underwearTopsType= underwearTopName;

    }

        public void Selectsock(string sockName)
    {
        clothingData.sockType= sockName;

    }

        public void SelectPants(string pantsName)
    {
        clothingData.pantsType= pantsName;

    }

        public void Selectshirt(string shirtName)
    {
        clothingData.shirtType= shirtName;

    }

        public void SelectThickShirt(string thickShirtName)
    {
        clothingData.thickShirtType= thickShirtName;

    }

        public void SelectJacket(string jacketName)
    {
        clothingData.jacketType= jacketName;
    }

        public void SelectExtraSun(string sunName)
    {
        clothingData.extraSunType= sunName;

    }

        public void SelectExtraSnow(string snowName)
    {
        clothingData.extraSnowType= snowName;

    }

        public void SelectExtraRain(string rainName)
    {
        clothingData.extraRainType= rainName;

    }

        public void SelectExtraCold(string coldName)
    {
        clothingData.extraColdType= coldName;

    }

    void DressUp()
    {
        SelectUnderwearTop(clothingData.underwearTopsType);
        SelectUnderwear(clothingData.underwearType);
        Selectsock(clothingData.sockType);
        SelectPants(clothingData.pantsType);
        Selectshirt(clothingData.shirtType);
        SelectThickShirt(clothingData.thickShirtType);
        SelectShoes(clothingData.shoeType);
        SelectJacket(clothingData.jacketType);
        SelectExtraSun(clothingData.extraSunType);
        SelectExtraSnow(clothingData.extraSnowType);
        SelectExtraRain(clothingData.extraRainType);
        SelectExtraCold(clothingData.extraColdType);
    }

    void OnApplicationQuit()
    {
        clothingData.Reset();
        Debug.Log("quitting");
    }
    
}

