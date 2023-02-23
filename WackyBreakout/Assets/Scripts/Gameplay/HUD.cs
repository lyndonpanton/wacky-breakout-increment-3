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
    // Start is called before the first frame update
    void Start()
    {
        ballsLeftValue = ConfigurationUtils.NumberOfBalls;
        ballsLeftText.text = ballsLeftPrefix + ballsLeftValue.ToString();
        ballsLeftTextObject = ballsLeftText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void lostBall()
    {
        ballsLeftValue--;
        ballsLeftTextObject.text = ballsLeftPrefix + ballsLeftValue.ToString();
    }
}
