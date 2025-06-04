using UnityEngine;


public class EnergyPoint : MonoBehaviour
{
    public float bounceForce = 10f;
    public int bonusScore = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            }

            UIManager.instance.AddScore(bonusScore);
        }
    }
}

