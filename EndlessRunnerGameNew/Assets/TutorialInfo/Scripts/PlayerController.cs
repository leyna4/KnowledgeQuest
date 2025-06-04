using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class PlayerController : MonoBehaviour
{
    public bool isAlive = true;
    public float RunSpeed;
    public float HorizontalSpeed;
    public Rigidbody rb;
    float horizantalInput;

    [SerializeField] private float Jumpforce = 350;
    [SerializeField] private LayerMask GroundMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(isAlive)
        {
            Vector3 forwardMovement = transform.forward * RunSpeed * Time.fixedDeltaTime;
            Vector3 horizontalmovement = transform.right * horizantalInput * HorizontalSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMovement + horizontalmovement);
        }

       
    }


    void Update()
    {
        horizantalInput = Input.GetAxis("Horizontal");

        float playerHeight = GetComponent<Collider>().bounds.size.y;
        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, (playerHeight / 2) + 0.1f, GroundMask);

        if (Input.GetKeyDown(KeyCode.Space) && isAlive && IsGrounded == true)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * Jumpforce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "cube")
        {
            Dead();
        }
    }

    public void Dead()
    {
        isAlive = false;
    }
}
