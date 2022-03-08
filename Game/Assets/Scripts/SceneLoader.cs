using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class SceneLoader : MonoBehaviour
{

    public string SceneToLoad;
    
    public void LoadScene()
    {
        string currScene = SceneManager.GetActiveScene().ToString();
        print(currScene);
        print("Loading");
        SceneManager.LoadScene(SceneToLoad);
    }
}