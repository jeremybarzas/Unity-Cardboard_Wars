using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas controlsScreen;

    public void onSinglePlayerClicked(string value)
    {
        GameState.Instance.LoadScene(value);
    }
  
    public void onMultiplayerClicked(string value)
    {
        GameState.Instance.LoadScene(value);
    }

    public void onControlsClicked()
    {
        mainMenu.enabled = false;
        controlsScreen.enabled = true;
    }
    public void onExitToDesktopClicked()
    {
        GameState.Instance.QuitGame();
    }

    public void onBackClicked()
    {
        controlsScreen.enabled = false;
        mainMenu.enabled = true;
    }

    void Start()
    {
        mainMenu.enabled = true;
        controlsScreen.enabled = false;
    }
}