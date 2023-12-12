using System;
using TMPro;
using UnityEngine;


public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private void Awake()
    {
        // Singleton
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }

    private void Score_OnHighScoreChange(object sender, EventArgs e)
    {
        UpdateHighScoreText();
    }

    public void UpdateHighScoreText()
    {
        int highScore = Score.GetHighScore();
        highScoreText.text = highScore.ToString();
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
