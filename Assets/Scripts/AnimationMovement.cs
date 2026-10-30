using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody))]
public class AnimationMovement : MonoBehaviour
{
    private Animator animator;
    private new Rigidbody rigidbody;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();

        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    private void OnAnimatorMove()
    {
        Vector3 animationDeltaPosition = animator.deltaPosition;

        animationDeltaPosition.y = 0f;

        rigidbody.MovePosition(rigidbody.position + animationDeltaPosition);
        rigidbody.MoveRotation(rigidbody.rotation * animator.deltaRotation);
    }
}
