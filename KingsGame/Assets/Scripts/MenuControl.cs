using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour {
    public void OpenGameScene()
    {
        Application.LoadLevel(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
