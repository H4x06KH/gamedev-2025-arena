using UnityEngine;

public class Kick : MonoBehaviour
{
    public float strength = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballBody = collision.gameObject.GetComponent<Rigidbody>();
            if (ballBody != null)
            {                
                if (collision.contactCount == 0)
                {
                    Debug.LogWarning("No contact points found in collision.");
                    return;
                }
                ContactPoint mainContactPoint = collision.GetContact(0);
                Vector3 mainCollisionDirection = mainContactPoint.impulse.normalized;
                Debug.Log($"Kicking the ball! Direction = {mainCollisionDirection}");
                ballBody.AddForce(mainCollisionDirection * strength, ForceMode.Impulse);
            }
        }
    }
}
