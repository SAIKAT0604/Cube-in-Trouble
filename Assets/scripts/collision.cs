
using UnityEngine;

public class collision : MonoBehaviour {

    public playermovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
