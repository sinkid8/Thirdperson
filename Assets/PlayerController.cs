using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score = 0; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 1; 
            Debug.Log("Coin Collected! Score: " + score);
            Destroy(other.gameObject); 
        }
    }
}
