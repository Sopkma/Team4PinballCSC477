using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameoverMenu;
    public GameObject gameHUD;
    

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        gameoverMenu.SetActive(false);
        gameHUD.SetActive(false);
        Game.Instance.input.Disable(); // lecture
    }

    public void StartGame() {
        mainMenu.SetActive(false);
        gameHUD.SetActive(true);
        Game.Instance.input.Enable(); // lecture
    }

    public void GameOver() { // lecture
        gameoverMenu.SetActive(true);
        gameHUD.SetActive(false);
        Game.Instance.input.Disable();
    }

    public void RestartGame() {
        gameoverMenu.SetActive(false);
        gameHUD.SetActive(true);
        Game.Instance.input.Enable();
    }
}
