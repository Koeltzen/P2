using UnityEngine;

public class TempBar : MonoBehaviour
{
    public float Temp = 0f;
    public float MaxTemp = 100f;

    [SerializeField] 
    private RectTransform thermometer;

    [SerializeField] 
    private float width = 200f;

    [SerializeField] 
    private float height = 50f;

    void Start()
    {
        UpdateBar(); // initialize correctly
    }

    public void AddTemp(float amount)
    {
        Debug.Log("Adding temp: " + amount);

        Temp += amount;
        Temp = Mathf.Clamp(Temp, 0, MaxTemp);

        UpdateBar();
    }

    private void UpdateBar()
    {
        if (thermometer == null) return;
        if (MaxTemp <= 0f) return;

        float normalized = Temp / MaxTemp;

        float newWidth = normalized * width;
        thermometer.sizeDelta = new Vector2(newWidth, height);
    }
}