﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevel : MonoBehaviour {

   public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
