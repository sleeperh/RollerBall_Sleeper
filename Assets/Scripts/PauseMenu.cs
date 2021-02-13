using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseText;
    public GameObject continueText;
    public GameObject restartButton;
    public GameObject MenuButton;
    public GameObject quitButton;

    bool pause = false;
    private void Start()
    {
        PauseMenuUI(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if(!pause)
            {
                PauseMenuUI(true);
                pause = true;
            }
            else if(pause)
            {
                PauseMenuUI(false);
                pause = false;
            }
        }
    }

    public void PauseMenuUI(bool activeBool)
    {
        pausePanel.SetActive(activeBool);
        pauseText.SetActive(activeBool);
        continueText.SetActive(activeBool);
        quitButton.SetActive(activeBool);
        restartButton.SetActive(activeBool);
        MenuButton.SetActive(activeBool);
        if (activeBool)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
