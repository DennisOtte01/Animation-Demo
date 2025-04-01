using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float jumpForce = 200f;
    [SerializeField] private float torqueForce = 10f;
    [SerializeField] private float movementSpeed = 500f;

    private float rotationInput = 0f;
    private float movementInput = 0f;

    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // Add var for checking direction for blend tree
    }

    private void FixedUpdate()
    {
        Vector3 movement = transform.forward * (movementInput * movementSpeed * Time.fixedDeltaTime);
        rb.AddTorque(Vector3.up * (rotationInput * torqueForce));
        rb.AddForce(movement);
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<float>();
    }

    void OnTurn(InputValue turnValue)
    {
        rotationInput = turnValue.Get<float>();
    }

    void OnJump()
    {
        animator.SetTrigger("Jump");
        rb.AddForce(Vector3.up * jumpForce);
    }
}
