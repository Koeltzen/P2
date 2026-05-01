using UnityEngine;

public class ClothingItem : MonoBehaviour
{
    public string category;   // "hat", "shirt", etc.
    public float value = 1f;

    public void SelectItem()
    {
        ScoreManager.Instance.SetItem(category, value);
        Debug.Log($"{category} selected with value {value}");
    }
}