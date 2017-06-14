using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSceneButtonBehaviour : MonoBehaviour
{
    public Canvas pauseMenu;
    public Canvas controls;
    private bool paused;

    public void onResumeClicked()
    {
        pauseMenu.enabled = false;
        GameState.Instance.UnpauseGame();
        paused = false;
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
        GameState.Instance.UnpauseGame();
        paused = false;
        pauseMenu.enabled = false;
        controls.enabled = false;
    }

    void Update()
    {
        if (!paused)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                paused = true;
                pauseMenu.enabled = true;
                GameState.Instance.PauseGame();
            }
        }
    }
}
