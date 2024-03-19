using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private GameInputs input;
    public Ball ball;
    public Flipper leftFlipper;
    public Flipper rightFlipper;

    void Start()
    {
        input = new GameInputs();
        input.Enable();
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
}
