using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text scoreText;
    public int totalScore;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void updateScoreText()
    {
        scoreText.text = "x" + totalScore.ToString();
    }
}
