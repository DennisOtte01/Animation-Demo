using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float jumpForce = 200f;
    [SerializeField] private float movementSpeed = 400f;
    [SerializeField] private float strafeSpeed = 200f;

    private float strafeInput = 0f;
    private float movementInput = 0f;
    

    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 localVelocity = transform.InverseTransformDirection(rb.linearVelocity);
        animator.SetFloat("x", localVelocity.x);
        animator.SetFloat("y", localVelocity.z);
    }
    
    private void FixedUpdate()
    {
        Vector3 forwardMovement = transform.forward * (movementInput * movementSpeed * Time.fixedDeltaTime);
        Vector3 strafeMovement = transform.right * (strafeInput * strafeSpeed * Time.fixedDeltaTime);

        Vector3 movement = forwardMovement + strafeMovement;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<float>();
    }

    void OnStrafe(InputValue movementValue)
    {
        strafeInput = movementValue.Get<float>();
    }
    
    void OnJump()
    {
        animator.SetTrigger("Jump");
        rb.AddForce(Vector3.up * jumpForce);
    }
}
