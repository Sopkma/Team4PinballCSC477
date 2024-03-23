using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public GameInputs input; 
    public Ball ball;
    public Flipper leftFlipper;
    public Flipper rightFlipper;
    public Score score; // lec

    public static Game Instance { get; private set; } 

    public int CurScore { get; private set; }
    public int HighScore { get; private set; }

    private void Awake() // awake starts first over start lecture
    {
        input = new GameInputs();
        input.Enable();
        Instance = this; // lecture
    }

    //private void Start() {
    //    HighScore = PlayerPrefs.GetInt(PlayerPrefs.HighScore, 0);
    //}

    void Update()
    {
        if (input.Player.FlipperRight.WasPressedThisFrame()) {
            rightFlipper.flip();
        } 
        else if (input.Player.FlipperLeft.WasPressedThisFrame()) {
            leftFlipper.flip();
        }
    }

    public void AddScore(int amount) {
        score.AddScore(amount);
        CurScore += amount;
        if (CurScore >= HighScore) {
            HighScore = CurScore;
        }
    }
}
