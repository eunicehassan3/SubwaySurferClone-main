using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    
   private void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "Destroy" && gameObject != null){
        Destroy(gameObject);
    }
     }

}
