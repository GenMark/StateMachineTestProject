using UnityEngine;
using System.Collections;

public class SceneButtonsOnClick : MonoBehaviour {

    public void OnClickButton(string name) {
        Debug.Log("OnClickButton -> " + name);
        switch (name) {
            case "Options":
                StateMachine.SetEvent(GameStateMachine.eOnOption);
                break;
            case "Game":
                StateMachine.SetEvent(GameStateMachine.eOnGame);
                break;
            case "MainMenu":
                StateMachine.SetEvent(GameStateMachine.eOnMainMenu);
                break;
            case "Pause":
                StateMachine.SetEvent(GameStateMachine.eOnPause);
                break;
            case "Fail":
                StateMachine.SetEvent(GameStateMachine.eGameOver);
                break;
            case "Win":
                StateMachine.SetEvent(GameStateMachine.eGameComplete);
                break;
        }
    }
}
