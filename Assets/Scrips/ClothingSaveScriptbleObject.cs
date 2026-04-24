using UnityEngine;


[CreateAssetMenu(fileName = "CharacterClothing", menuName = "Game/Character Clothing")]
public class CharacterClothing : ScriptableObject
{
    public string underwearType;
    public string underwearTopsType;
    public string pantsType;
    public string shirtType;
    public string thickShirtType;
    public string sockType;
    public string shoeType;
    public string jacketType;
    public string extraSunType;
    public string extraRainType;
    public string extraColdType;
    public string extraSnowType;


    public void Reset()
    {
        underwearType = null;
        underwearTopsType = null;
        sockType = null;
        pantsType = null;
        shirtType = null;
        thickShirtType = null;
        shoeType = null;
        jacketType = null;
        extraColdType = null;
        extraRainType = null;
        extraSnowType = null;
        extraSunType = null; 
    }
}

