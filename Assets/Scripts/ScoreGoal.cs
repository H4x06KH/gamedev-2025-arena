using TMPro;
using UnityEngine;

public class ScoreGoal : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    private Vector3 ballStartPosition = new Vector3(0, 3, 0);

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Goal scored in " + gameObject.name);
            score++;
            UpdateScoreText();
            collision.gameObject.transform.position = ballStartPosition;
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
