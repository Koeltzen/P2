using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scaneTalkManager : MonoBehaviour
{
        // Store the scene that should trigger start

    public AndeTalk m_Andetalk;
    private UnityEngine.SceneManagement.Scene scene;

    private void Awake()
    {
        // It is save to remove listeners even if they
        // didn't exist so far.
        // This makes sure it is added only once
        SceneManager.sceneLoaded -= OnSceneLoaded;

        // Add the listener to be called when a scene is loaded
        SceneManager.sceneLoaded += OnSceneLoaded;

        DontDestroyOnLoad(gameObject);

        // Store the creating scene as the scene to trigger start
        scene = SceneManager.GetActiveScene();
    }

    private void OnDestroy()
    {
        // Always clean up your listeners when not needed anymore
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Listener for sceneLoaded
    public void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
    {
        // return if not the start calling scene
        if(!string.Equals(scene.path, this.scene.path))return;

        Debug.Log("Re-Initializing", this);
        // do your "Start" stuff here

        m_Andetalk.ButtonClick();
        

    }
}

