using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroSceneTransition : MonoBehaviour
{
   public string scene;
   public void Transition()
   {
       SceneManager.LoadScene(scene, LoadSceneMode.Single);
   }
 
}