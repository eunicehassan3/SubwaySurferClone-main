using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    public Vector3 jump;
    public float jumpForce = 10.0f;
    private bool isGrounded;
    // public float fallMultiplier = 2.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        // gameObject.transform.posit ion = new Vector3(0f,1.13f,-94.1f);
    }

    void OnCollisionStay(){
    		isGrounded = true;
    	}

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(transform.forward * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            gameObject.transform.position = transform.position + new Vector3(-7f,0,0);
            
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            gameObject.transform.position = transform.position + new Vector3(7,0,0);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded ){
           
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    		isGrounded = false;
            
        }

    }

    float CalculateJumpForce(float height, float gravity, float mass)
{
    return Mathf.Sqrt(height * gravity * -2) * mass;
}
}
