using UnityEngine;
using UnityEngine.SceneManagement;

public class TermoCheck : MonoBehaviour
{
    private static TermoCheck instance;
    public static float Stress;
    public float MaxStress;

    [SerializeField]
    private Termometer stressBar;
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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stressBar.MaxStress = MaxStress;
        SetStress(20f);
    }

    public void SetStress(float stressChange)
    {
        Stress += stressChange;
        Stress = Mathf.Clamp(Stress, 0, MaxStress);

        stressBar.SetStress(Stress);
    
    }

}