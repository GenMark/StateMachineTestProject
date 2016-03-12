using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SMStatePause : State {

    public override void StartState() {
        Debug.Log("SMStatePause: StartState");
        SceneManager.LoadScene("Pause");
    }

    public override void StopState() {
        Debug.Log("SMStatePause: StopState");
    }
}
