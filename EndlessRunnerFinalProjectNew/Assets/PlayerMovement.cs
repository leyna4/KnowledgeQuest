using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float forwardSpeed;
    public float laneDistance;
    int currentLane = 2;
    int fixedLaneCount = 3;
    int jumpCount = 0;
    int maxJumps = 2;

    private float jumpForce = 5f;

    private Animator animator;

    private float originalSpeed;

    public float moveSpeed = 10f;
    public float minSpeed = 5f;
    public float maxSpeed = 20f;

    public void ChangeSpeed(float amount)
    {
        moveSpeed += amount;
        moveSpeed = Mathf.Clamp(moveSpeed, minSpeed, maxSpeed);
        Debug.Log("Yeni hýz: " + moveSpeed);
    }



    void Awake()
    {
        animator = GetComponent<Animator>();
        originalSpeed = forwardSpeed;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && currentLane > 1) {
            currentLane--;
            transform.Translate(-laneDistance, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && currentLane < fixedLaneCount) {
            currentLane++;
            transform.Translate(laneDistance, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
            animator.SetTrigger("Jump");
            jumpCount++;
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                GameManager.instance.GameOver();
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("SpeedUp"))
            {
                forwardSpeed += 5f;
                Debug.Log("Hýzlandý!");
                Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("SlowDown"))
            {
                forwardSpeed = Mathf.Max(2f, forwardSpeed - 3f);
                Debug.Log("Yavaþladý!");
                Destroy(other.gameObject);
            }


        }


    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * forwardSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }


    }



}
