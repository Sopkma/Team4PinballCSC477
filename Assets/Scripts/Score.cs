using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum ScoreType {
    CURRENT,
    HIGH
}

[RequireComponent(typeof(TextMeshProUGUI))]
public class Score : MonoBehaviour
{
    public ScoreType type;
    private TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (type == ScoreType.CURRENT) {
            txt.text = Game.Instance.CurScore.ToString();
        } else if (type == ScoreType.HIGH) {
            txt.text = Game.Instance.HighScore.ToString();
        }
    }
}
