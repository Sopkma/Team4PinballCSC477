using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bumper : MonoBehaviour
{
    private float BumperTransitionTimer;
    private Renderer BumperTextureRenderer;

    // RGB colors from the Citrink palette
    // note all custom colors seem to break the bumper color change for some reason...?
    private Color White = Color.white;
    private Color Yellow = new Color(252f, 246f, 96f);
    private Color Lime = new Color(178f, 217f, 66f);
    private Color Green = new Color(82f, 195f, 63f);
    private Color LighterBlue = new Color(22f, 110f, 122f);
    private Color DarkerBlue = new Color(37f, 77f, 112f);
    private Color LighterPurple = new Color(37f, 36f, 70f);
    private Color DarkerPurple = new Color(32f, 21f, 51f);


    // Start is called before the first frame update
    void Start()
    {
        BumperTransitionTimer = 0;
        BumperTextureRenderer = GetComponent<Renderer>();
        BumperTextureRenderer.material.SetColor("_BaseColor", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        if (BumperTransitionTimer > 0)
        {
            Color color = Color.Lerp(Color.blue, White, BumperTransitionTimer);
            BumperTextureRenderer.material.SetColor("_BaseColor", color);
            BumperTransitionTimer -= Time.deltaTime / 2.0f;
            if (BumperTransitionTimer < 0)
            {
                BumperTransitionTimer = 0;
            }
        }
    }

    public void Bump()
    {
        BumperTransitionTimer = 1;
        BumperTextureRenderer.material.SetColor("_BaseColor", White);
    }
}
