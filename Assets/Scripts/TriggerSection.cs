using JetBrains.Annotations;
using UnityEngine;

public class TriggerSection : MonoBehaviour
{
    public GameObject trainPrefab;
    public GameObject[] backgroundPrefabs;
    public int roadLength = 2;
    public int offset = 0;
    
   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Trigger"){
        Instantiate(trainPrefab, new Vector3(0,0, 60), Quaternion.identity);
        for(int i = 1; i <= roadLength; i++){
            int luckyNum = Random.Range(0, backgroundPrefabs.Length);
            int luckyNum2 = Random.Range(0, backgroundPrefabs.Length);
            Instantiate(backgroundPrefabs[luckyNum], new Vector3(-20,0, 60 + offset), Quaternion.identity);
            Instantiate(backgroundPrefabs[luckyNum2], new Vector3(20,0, 60 + offset), Quaternion.identity);
            offset += 20;
            }
            offset = 0;
        } 
    }
}
