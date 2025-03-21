using JetBrains.Annotations;
using UnityEngine;

public class TriggerSection : MonoBehaviour
{
    public GameObject trainPrefab;
    public GameObject[] backgroundPrefabs;
    private float start = 110;
    public int roadLength = 2;
    public int offset = 0;

    void Update()
    {
        Debug.Log("Start Value:" + start);
        Debug.Log("offset:" + offset);
    }

    private void OnTriggerEnter(Collider other){
    // float startPos = startObject.transform.position.z;
    if(other.gameObject.tag == "Trigger"){
        // Instantiate(trainPrefab, new Vector3(0,0, 206), Quaternion.identity);
        Instantiate(trainPrefab, new Vector3(17.0519f,5.521738f, 100 ), Quaternion.identity);
        // for(int i = 1; i <= roadLength; i++){
        //     int luckyNum = Random.Range(0, backgroundPrefabs.Length);
        //     int luckyNum2 = Random.Range(0, backgroundPrefabs.Length);
        //     Instantiate(backgroundPrefabs[luckyNum], new Vector3(-20,0, start + offset), Quaternion.identity);
        //     Instantiate(backgroundPrefabs[luckyNum2], new Vector3(20,0, start + offset), Quaternion.identity);
        //     offset += 20;
        //     }
            
            offset = 0;
        } 
    }
}

  
