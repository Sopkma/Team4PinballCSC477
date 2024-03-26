using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bumper : MonoBehaviour
{
    private float BumperTransitionTimer;
    private Renderer BumperTextureRenderer;
    private Color bumperOGColor;

    public int colorChoice;

    // RGB colors from the Citrink palette
    // NOTE: values must be between 0 and 1
    private Color White = Color.white;
    private Color Yellow = new Color(252f / 255f, 246f / 255f, 96f / 255f);
    private Color Lime = new Color(178f / 255f, 217f / 255f, 66f / 255f);
    private Color Green = new Color(82f / 255f, 195f / 255f, 63f / 255f);
    private Color LighterBlue = new Color(22f / 255f, 110f / 255f, 122f / 255f);
    private Color DarkerBlue = new Color(37f / 255f, 77f / 255f, 112f / 255f);
    private Color LighterPurple = new Color(37f / 255f, 36f / 255f, 70f / 255f);
    private Color DarkerPurple = new Color(32f / 255f, 21f / 255f, 51f / 255f);


    // Start is called before the first frame update
    void Start()
    {
        BumperTransitionTimer = 0;
        BumperTextureRenderer = GetComponent<Renderer>();
        bumperOGColor = BumperTextureRenderer.material.color;
        //BumperTextureRenderer.material.SetColor("_BaseColor", DarkerPurple);
    }

    // Update is called once per frame
    void Update()
    {
        if (BumperTransitionTimer > 0)
        {
            if (colorChoice == 1)
            {
                Color color = Color.Lerp(bumperOGColor, LighterBlue, BumperTransitionTimer);
                BumperTextureRenderer.material.SetColor("_BaseColor", color);
                BumperTransitionTimer -= Time.deltaTime / 2.0f;
            }
            else if (colorChoice == 2)
            {
                Color color = Color.Lerp(bumperOGColor, Green, BumperTransitionTimer);
                BumperTextureRenderer.material.SetColor("_BaseColor", color);
                BumperTransitionTimer -= Time.deltaTime / 2.0f;
            } 
            else if (colorChoice == 3)
            {
                Color color = Color.Lerp(bumperOGColor, White, BumperTransitionTimer);
                BumperTextureRenderer.material.SetColor("_BaseColor", color);
                BumperTransitionTimer -= Time.deltaTime / 2.0f;
            }
            else
            {
                Color color = Color.Lerp(bumperOGColor, Yellow, BumperTransitionTimer);
                BumperTextureRenderer.material.SetColor("_BaseColor", color);
                BumperTransitionTimer -= Time.deltaTime / 2.0f;
            }
            
            if (BumperTransitionTimer < 0)
            {
                BumperTransitionTimer = 0;
            }
        }
    }

    public void Bump()
    {
        BumperTransitionTimer = 1;
        BumperTextureRenderer.material.SetColor("_BaseColor", Yellow);
    }
}
