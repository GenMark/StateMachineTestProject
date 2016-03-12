using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStateGame : State {

    public override void StartState() {
        Debug.Log("SMStateGame: StartState");
        SceneManager.LoadScene("Game");
    }

    public override void StopState() {
        Debug.Log("SMStateGame: StopState");
    }
}
