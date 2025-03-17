using UnityEngine;
using UnityEngine.AI;
using System.Collections;

//modified with chatGPT YT tutorial
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform[] spawnPoints; 
    public float spawnInterval = 11f; 
    public float leftTrackX = -2.5f; // X position for the left track
    public float middleTrackX = 0f; // X position for the middle track
    public float rightTrackX = 2.5f; // X position for the right track
    public float spawnY = 0f; // Y position for spawning obstacles
    public float spawnZ = 20f; // Z position where obstacles will appear
    public float lastspawnZ;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            spawnObstacles();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // void SpawnObstacle()
    // {
    //     if (obstacles.Length == 0 || spawnPoints.Length < 3)
    //     {
    //         Debug.LogError("Obstacles or spawn points are not set correctly!");
    //         return;
    //     }

    //     float[] trackPositions = { leftTrackX, middleTrackX, rightTrackX };
    //     int trackIndex = Random.Range(0, trackPositions.Length); // Choose a random track
    //     int obstacleIndex = Random.Range(0, obstacles.Length); // Choose a random obstacle
        
    //     Vector3 spawnPosition = new Vector3(trackPositions[trackIndex], spawnY, spawnZ);
    //     Instantiate(obstacles[obstacleIndex], spawnPosition, Quaternion.identity);
        
        // int trackIndex = Random.Range(0, spawnPoints.Length); // Random track (0 = left, 1 = middle, 2 = right)
        // int obstacleIndex = Random.Range(0, obstacles.Length); // Random obstacle
        
        // Instantiate(obstacles[obstacleIndex], spawnPoints[trackIndex].position, Quaternion.identity);
    // }
  
   
    private void spawnObstacles(){
        // lastspawnZ += spawnAmount;

        for(int i = 0; i < obstacles.Length;  i++){
            if(Random.Range(0,4) == 0){
                GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
                Vector3 obstaclePos = new Vector3(0,0,lastspawnZ);
                Instantiate(obstacle, obstaclePos, Quaternion.identity);
            }
        }

    }
}