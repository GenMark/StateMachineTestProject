using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStateGameOver : State {

    public override void StartState() {
        Debug.Log("SMStateGameOver: StartState");
        SceneManager.LoadScene("Fail");
    }

    public override void StopState() {
        Debug.Log("SMStateGameOver: StopState");
    }
}
