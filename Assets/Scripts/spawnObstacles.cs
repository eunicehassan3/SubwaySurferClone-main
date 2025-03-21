using UnityEngine;
using UnityEngine.AI;
using System.Collections;


//modified with chatGPT YT tutorial
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject[] obstacles;
    public float spawnZ = 50;
    public float offset = 10;
    

    void Start()
    {
        // spawnObstacles2();
        StartCoroutine(SpawnRoutine());
    }

    void Update()
    {
        
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // spawnZ += offset;
            spawnObstacles2();
            yield return new WaitForSeconds(4);
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
        GameObject obstacle1 = obstacles[Random.Range(0, obstacles.Length)];
        GameObject obstacle2 = obstacles[Random.Range(0, obstacles.Length)];
        GameObject obstacle3 = obstacles[Random.Range(0, obstacles.Length)];
        
        Vector3 posM = new Vector3(0,2.6f,spawnZ);
        Vector3 posL = new Vector3(-7,2.6f,spawnZ);
        Vector3 posR = new Vector3(7,2.6f,spawnZ);
        Instantiate(obstacle1, posM, obstacle1.transform.rotation);
        Instantiate(obstacle2, posL, obstacle2.transform.rotation);
        Instantiate(obstacle3, posR, obstacle3.transform.rotation);
        
    }
   

}