using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeToMainGame(){
        SceneManager.LoadScene("MainGame");

    }
    public void changeToGameOver(){
        SceneManager.LoadScene("GameOver");
    }
}
