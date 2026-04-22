using System.Buffers;
using UnityEngine;
using UnityEngine.UI;

public class Termometer : MonoBehaviour
{
    private static Termometer instance;

    public float Stress, MaxStress, Width, Height;

    [SerializeField]
    private RectTransform Stressbar;

 void Awake()
     {
    
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
       
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetMaxStress(float maxStress)
    {
        MaxStress = maxStress;
    }

    public void SetStress(float stress)
    {
        Stress = stress;
        float newWidth = (Stress/MaxStress)*Width;

        //Stressbar.sizeDelta = new Vector2(newWidth, Height);
        Stressbar.transform.localScale = new Vector3(stress/MaxStress, 1, 1);
    }
}