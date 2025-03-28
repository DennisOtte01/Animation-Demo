using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    Animator animator;
    Rigidbody rigidbody;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        rigidbody.linearVelocity = move * 5f;
    }
}
