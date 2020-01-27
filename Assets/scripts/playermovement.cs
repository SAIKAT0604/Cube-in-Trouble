using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 20f;
    public float sideforce = 50f;
	

	void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
               
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            }
            else if (touch.position.x > Screen.width / 2)
            {
                
                rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0,0 ,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }


    }
}
