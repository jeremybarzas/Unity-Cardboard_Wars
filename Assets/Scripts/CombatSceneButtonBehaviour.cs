using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneButtonBehaviour : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas controls;

    public void onResumeClicked()
    {
        pauseMenu.enabled = false;
        GameState.Instance.UnpauseGame();
    }

    public void onControlsClicked()
    {
        pauseMenu.enabled = false;
        controls.enabled = true;
    }

    public void onBackClicked()
    {
        controls.enabled = false;
        pauseMenu.enabled = true;
    }

    public void onMainMenuClicked(string value)
    {
        GameState.Instance.LoadScene(value);
    }

    public void onExitClicked()
    {
        GameState.Instance.QuitGame();
    }

    void Start()
    {
        pauseMenu.enabled = false;
        controls.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
            GameState.Instance.PauseGame();
        }
    }
}
