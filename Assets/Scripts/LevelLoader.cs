﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public string sceneToLoad = "StartScene";


    public void loadTheLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
