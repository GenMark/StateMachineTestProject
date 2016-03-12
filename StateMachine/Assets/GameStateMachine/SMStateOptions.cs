using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStateOptions : State {

    public override void StartState() {
        Debug.Log("SMStateOptions: StartState");
        SceneManager.LoadScene("Options");
    }

    public override void StopState() {
        Debug.Log("SMStateOptions: StopState");
    }
}
