using UnityEngine;

public class Gravity : MonoBehaviour
{
    private new Rigidbody rigidbody;

    private bool onGround;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!onGround)
        {
            rigidbody.AddForce(Physics.gravity, ForceMode.Acceleration);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
}
