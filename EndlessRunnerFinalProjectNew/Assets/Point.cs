using UnityEngine;

public enum PointType { Score, SpeedUp, SlowDown }

public class Point : MonoBehaviour
{
    public PointType pointType = PointType.Score;
    public float speedChangeAmount = 2f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (pointType == PointType.Score)
            {
                GameManager.instance.AddScore();
            }
            else if (pointType == PointType.SpeedUp)
            {
                GameManager.instance.ChangePlayerSpeed(speedChangeAmount);
            }
            else if (pointType == PointType.SlowDown)
            {
                GameManager.instance.ChangePlayerSpeed(-speedChangeAmount);
            }

            Destroy(this.gameObject);

                GameManager.instance.AddScore();  // Skor artýþý
                GameManager.instance.ChangePlayerSpeed(speedChangeAmount); // Hýz deðiþimi
                Destroy(this.gameObject);
        

        }
    }

}
