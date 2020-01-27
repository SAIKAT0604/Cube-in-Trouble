using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {

    bool GameHasEnded = false;
    public float restartdelay = 1f;
    public GameObject completelevelui;
    public void levelcomolete()
    {
        completelevelui.SetActive(true);
    }
    public void EndGame()
    {
        if(GameHasEnded==false)
        {
            GameHasEnded = true;
            Debug.Log("Game over");
            Invoke("restart", restartdelay);
        }


       
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
