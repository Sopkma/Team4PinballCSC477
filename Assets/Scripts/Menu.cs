using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameoverMenu;
    

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        gameoverMenu.SetActive(false);
        Game.Instance.input.Disable(); // lecture
    }

    public void StartGame() {
        mainMenu.SetActive(false);
        Game.Instance.input.Enable(); // lecture
    }

    public void GameOver() { // lecture
        gameoverMenu.SetActive(true);
        Game.Instance.input.Disable();
    }

    public void Restart() {
        gameoverMenu.SetActive(false);
        Game.Instance.input.Enable();
    }
}
