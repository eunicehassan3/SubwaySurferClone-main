using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject player;
    private Vector3 leftOffset;
    private Vector3 rightOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftOffset = new Vector3(0, 10, -15);
        rightOffset = new Vector3(6, 10, -15);
    }

    // Update is called once per frame
    void Update()

    {
        gameObject.transform.position = player.transform.position + leftOffset;
        
        // if(Input.GetKeyDown(KeyCode.LeftArrow)){
        //     gameObject.transform.position = player.transform.position + leftOffset;
        // }
        // if(Input.GetKeyDown(KeyCode.RightArrow)){
        //     gameObject.transform.position = player.transform.position + rightOffset;
        // }

    }
}
