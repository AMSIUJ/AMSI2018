using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public string sceneToLoad = "StartScreen";


    public void loadTheLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
