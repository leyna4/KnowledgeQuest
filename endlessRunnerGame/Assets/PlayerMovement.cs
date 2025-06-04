using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float forwardSpeed;
    public float laneDistance;
    int currentLane = 2;
    int fixedLaneCount = 3;

    private float jumpForce = 5f;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) &&  currentLane > 1){
            currentLane--;
            transform.Translate(-laneDistance, 0,0);
        }
        if(Input.GetKeyDown(KeyCode.D) && currentLane < fixedLaneCount){
            currentLane++;
            transform.Translate(laneDistance, 0,0);    
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.linearVelocity.y == 0)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("Jump");
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * forwardSpeed * Time.deltaTime);
    }
}
