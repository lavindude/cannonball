using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }

    public void gameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
