using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Text scoreText;
    public int totalScore;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void updateScoreText()
    {
        scoreText.text = "x" + totalScore.ToString();
    }

    public void showGameOver()
    {
        gameOver.SetActive(true);
    }

    public void restartGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }


}
