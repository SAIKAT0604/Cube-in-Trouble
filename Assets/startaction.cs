using UnityEngine;
using UnityEngine.SceneManagement;

public class startaction : MonoBehaviour {

	public void StartGame()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
