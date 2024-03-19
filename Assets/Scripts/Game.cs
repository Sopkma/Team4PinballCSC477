using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private GameInputs input;
    public Ball ball;

    void Start()
    {
        input = new GameInputs();
        input.Enable();
    }

    void Update()
    {
        if (input.Player.BallLaunch.WasReleasedThisFrame())
        {
            ball.Launch();
        }
    }
}
