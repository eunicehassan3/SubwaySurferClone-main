using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public float speed;
    public float acceleration; 
    private float currentSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2;
        currentSpeed = speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed += acceleration * Time.deltaTime;
        transform.Translate(-transform.forward * currentSpeed * Time.deltaTime);
        Debug.Log("Current Speed" +  currentSpeed);
    }


}
