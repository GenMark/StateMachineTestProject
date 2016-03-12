using UnityEngine;
using System.Collections;

public class SceneButtonsOnClick : MonoBehaviour {

    public void OnClickButton(string name) {
        Debug.Log("OnClickButton -> " + name);
        switch (name) {
            case "Options":
                StateMachine.SetEvent(StateMachine.smEvent.eOnOption);
                break;
            case "Game":
                StateMachine.SetEvent(StateMachine.smEvent.eOnGame);
                break;
            case "MainMenu":
                StateMachine.SetEvent(StateMachine.smEvent.eOnMainMenu);
                break;
            case "Pause":
                StateMachine.SetEvent(StateMachine.smEvent.eOnPause);
                break;
            case "Fail":
                StateMachine.SetEvent(StateMachine.smEvent.eGameOver);
                break;
            case "Win":
                StateMachine.SetEvent(StateMachine.smEvent.eGameComplete);
                break;
        }
    }
}
