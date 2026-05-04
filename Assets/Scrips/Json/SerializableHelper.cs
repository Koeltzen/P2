using JetBrains.Annotations;
using UnityEngine;

[System.Serializable]
public class ScoreInfo
{
   public string ClothingType;
   public string ClothingScore;
   public string ClothingDescription; 
}

public class SerializableHelper
{
    public static string SerializeScoreInfo(ScoreInfo scoInfo)
    {
        string json;
        json = JsonUtility.ToJson(scoInfo);

        if (json != null)
        {
            return json;
        }
        else
        {
            return null; 
        }

    }

    public static ScoreInfo DeserializeScoreInfo(string json)
    {
        ScoreInfo scoInfo = new ScoreInfo();
        scoInfo = JsonUtility.FromJson<ScoreInfo>(json);

        return scoInfo;
    }

}


