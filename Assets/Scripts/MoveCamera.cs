using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Handle rotation of camera based on keyboard input (Vertical-Horizontal axis)
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, horizontal);
        transform.Rotate(Vector3.right, -vertical);
    }
}
