using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStateGameComplete : State {

    public override void StartState() {
        Debug.Log("SMStateGameComplete: StartState");
        SceneManager.LoadScene("Win");
    }

    public override void StopState() {
        Debug.Log("SMStateGameComplete: StopState");
    }
}
