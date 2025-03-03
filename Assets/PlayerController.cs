using UnityEngine;
using UnityEngine.UI; 

public class PlayerController : MonoBehaviour
{
    public int score = 0; 
    public Text scoreText; 

    void Start()
    {
        UpdateScoreUI(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 1; 
            UpdateScoreUI(); 
            Destroy(other.gameObject); 
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
