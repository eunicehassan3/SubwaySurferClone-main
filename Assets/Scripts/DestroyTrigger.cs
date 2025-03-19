using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    
   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Destroy" && gameObject != null || gameObject.transform.position.y <= -7){
        Destroy(gameObject);
    }
     }

}
