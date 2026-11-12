using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Destroy(door);
            Destroy(gameObject);
        }
    }
}
