using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 10.0f;
    private GameObject ball;
    public GameObject targetGoal;
    Vector3 v;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
       ball = GameObject.Find("Ball");
        playerRb.isKinematic = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        v = ball.transform.position - (transform.position);
        v.y = 0;
        v = v.normalized;
        playerRb.AddForce(v * speed);

       
    }
}
