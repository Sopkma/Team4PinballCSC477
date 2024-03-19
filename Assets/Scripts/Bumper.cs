using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bumper : MonoBehaviour
{
    private float BumperTransitionTimer;
    private Renderer BumperTextureRenderer;
    private Color Purple = new Color(128f, 0f, 128f);

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
            Color color = Color.Lerp(Color.blue, Color.red, BumperTransitionTimer);
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
        BumperTextureRenderer.material.SetColor("_BaseColor", Color.red);
    }
}
