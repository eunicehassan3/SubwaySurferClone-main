using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public float speed;
    public float acceleration; 
    private float currentSpeed;
    // public float initialSpeed = 2f; 
    public float maxSpeed = 20f; 
    public float accelerationTime = 500f;
    private static float elapsedTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2;
        currentSpeed = speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        currentSpeed = Mathf.Lerp(speed, maxSpeed, elapsedTime / accelerationTime); 
        transform.position -= -transform.forward.normalized * currentSpeed * Time.deltaTime; 
        // currentSpeed += acceleration * Time.deltaTime;
        // transform.Translate(-transform.forward * currentSpeed * Time.deltaTime);
        // Debug.Log("Current Speed" +  currentSpeed);
    }


}
