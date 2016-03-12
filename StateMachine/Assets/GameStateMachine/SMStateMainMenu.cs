using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStateMainMenu : State {

    public override void StartState() {
        Debug.Log("SMStateMainMenu: StartState");
        if (SceneManager.GetActiveScene().name != "MainMenu") {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public override void StopState() {
        Debug.Log("SMStateMainMenu: StopState");
    }
}
