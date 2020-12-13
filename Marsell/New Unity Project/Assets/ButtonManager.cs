using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void startGame()
    {
        Application.LoadLevel(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
