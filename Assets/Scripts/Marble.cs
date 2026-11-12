using UnityEngine;

public class Marble : MonoBehaviour
{
    public GameObject deathUI;
    public GameObject winUI;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20f){
            deathUI.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "WinZone"){
            winUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
