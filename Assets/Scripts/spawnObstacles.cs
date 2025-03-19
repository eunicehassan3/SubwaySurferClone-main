using UnityEngine;
using UnityEngine.AI;
using System.Collections;


//modified with chatGPT YT tutorial
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject[] obstacles;
    

    void Start()
    {
        spawnObstacles2();
        // StartCoroutine(SpawnRoutine());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            spawnObstacles2();
            yield return new WaitForSeconds(2);
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

    private void spawnObstacles2(){
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
        Vector3 pos = new Vector3(0,2.6f,60);
        Instantiate(obstacle, pos, Quaternion.identity);
        
    }
   

}