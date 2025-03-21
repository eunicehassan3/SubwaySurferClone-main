using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    private float speed;
    public float acceleration; 
    private float currentSpeed;

    public float maxSpeed = 20f; 
    public float accelerationTime = 200;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 10;
        currentSpeed = speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        // elapsedTime += Time.deltaTime;
        // float elapsedTime = Time.timeSinceLevelLoad;
        // currentSpeed = Mathf.Lerp(speed, maxSpeed, elapsedTime / accelerationTime); 
        // transform.position -= Vector3.forward.normalized * currentSpeed * Time.deltaTime; 
        transform.position -= Vector3.forward.normalized * speed * Time.deltaTime; 

       
        // Debug.Log("Current Speed" +  currentSpeed);
    }


}
