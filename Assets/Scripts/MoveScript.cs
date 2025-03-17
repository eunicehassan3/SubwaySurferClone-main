using UnityEngine;

public class BackgroundBehavior : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.forward * speed * Time.deltaTime);
    }
}
