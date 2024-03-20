using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public GameInputs input; // lecture
    public Ball ball;
    public Flipper leftFlipper;
    public Flipper rightFlipper;
    public Score score; // lec

    public static Game Instance { get; private set; } // lecture

    void Awake() // awake starts first over start lecture
    {
        input = new GameInputs();
        input.Enable();
        Instance = this; // lecture
    }

    void Update()
    {
        if (input.Player.BallLaunch.WasReleasedThisFrame()) {
            ball.Launch();
        } 
        else if (input.Player.FlipperRight.WasPressedThisFrame()) {
            rightFlipper.flip();
        } 
        else if (input.Player.FlipperLeft.WasPressedThisFrame()) {
            leftFlipper.flip();
        }
    }

    public void AddScore(int amount) {
        score.AddScore(amount);
    }
}
