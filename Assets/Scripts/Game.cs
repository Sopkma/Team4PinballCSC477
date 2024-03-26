using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public GameInputs input; 
    public Ball ball;
    public Score score; // lec

    public static Game Instance { get; private set; } 

    public int CurScore { get; set; }
    public int HighScore { get; private set; }

    private void Awake() // awake starts first over start
    {
        input = new GameInputs();
        input.Enable();
        Instance = this; // lecture
    }

    private void Start() {
        HighScore = PlayerPrefs.GetInt(Constants.PlayerPrefs.HighScore, 0);
    }

    private void OnDisable() {
        PlayerPrefs.SetInt(Constants.PlayerPrefs.HighScore, HighScore);
    }

    public void AddScore(int amount) {
        CurScore += amount;
        if (CurScore >= HighScore) {
            HighScore = CurScore;
        }
    }
}
