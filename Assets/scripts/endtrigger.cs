using UnityEngine;

public class endtrigger : MonoBehaviour {

    public gamemanager GameManager;



    private void OnTriggerEnter()
    {
        GameManager.levelcomolete();
    }
}
