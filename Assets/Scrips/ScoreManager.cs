using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public OutfitData data = new OutfitData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetItem(string category, float value)
    {
        if (data.values.ContainsKey(category))
            data.values[category] = value;
        else
            data.values.Add(category, value);
    }

    public float GetTotalMultiplier()
    {
        float total = 1f;

        foreach (float value in data.values.Values)
        {
            total *= value;
        }

        return total;
    }
}