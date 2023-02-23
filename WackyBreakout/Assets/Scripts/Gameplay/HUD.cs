using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ballsLeftText;

    static TextMeshProUGUI ballsLeftTextObject;
    static string ballsLeftPrefix = "Balls Left: ";
    static int ballsLeftValue;

    [SerializeField]
    TextMeshProUGUI scoreText;

    static TextMeshProUGUI scoreTextObject;
    static string scorePrefix = "Score: ";
    static int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        ballsLeftValue = ConfigurationUtils.NumberOfBalls;
        ballsLeftText.text = ballsLeftPrefix + ballsLeftValue.ToString();
        ballsLeftTextObject = ballsLeftText;

        scoreValue = 0;
        scoreText.text = scorePrefix + scoreValue.ToString();
        scoreTextObject = scoreText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void LostBall()
    {
        ballsLeftValue--;
        ballsLeftTextObject.text = ballsLeftPrefix + ballsLeftValue.ToString();
    }

    public static void AddScore()
    {
        scoreValue++;
        scoreTextObject.text = scorePrefix + scoreValue.ToString();
    }
}
