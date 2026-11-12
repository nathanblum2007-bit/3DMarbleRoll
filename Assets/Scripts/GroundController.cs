using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        float xRotation = 0f;
        float zRotation = 0f;

        if(Input.GetKey(KeyCode.W)){
            xRotation += rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            xRotation -= rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            zRotation += rotationSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            zRotation -= rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(xRotation, 0f, zRotation, Space.Self);
    }
}
