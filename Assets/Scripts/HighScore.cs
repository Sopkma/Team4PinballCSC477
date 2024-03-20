using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private TextMeshProUGUI txt;
    private int highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore = 0;
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = highScore.ToString();
    }

    public void SubmitScore(int score) {
        if (highScore < score) {
            highScore = score;
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }
    public void ResetScore() {
        PlayerPrefs.DeleteKey("highscore");
    }
}
