using UnityEngine;
using System.Collections;

public class GameStateMachine : MonoBehaviour {
    public static GameStateMachine instance;
    public enum smEventTypes { };
     
    const int SMCountConnections = 12;
    StateConnection[] states;

    SMStateGame         smGame;
    SMStateGameComplete smGameComplete;
    SMStateGameOver     smGameOver;
    SMStateMainMenu     smMainMenu;
    SMStateOptions      smOptions;
    SMStatePause        smPause;
 
    void Start() {

        if (!StateMachine.TablePresent()) {
            Debug.Log("Start SM");
            // create states
            smMainMenu       = new SMStateMainMenu();
            smGame           = new SMStateGame();
            smGameComplete   = new SMStateGameComplete();
            smGameOver       = new SMStateGameOver();
            smOptions        = new SMStateOptions();
            smPause          = new SMStatePause();

            states = new StateConnection[SMCountConnections];
            // fill in the state machine table
            states[0] = new StateConnection(smMainMenu, StateMachine.smEvent.eOnOption, smOptions);
            states[1] = new StateConnection(smOptions, StateMachine.smEvent.eOnMainMenu, smMainMenu);
            states[2] = new StateConnection(smOptions, StateMachine.smEvent.eOnPause, smPause);
            states[3] = new StateConnection(smPause, StateMachine.smEvent.eOnOption, smOptions);
            states[4] = new StateConnection(smPause, StateMachine.smEvent.eOnGame, smGame);
            states[5] = new StateConnection(smPause, StateMachine.smEvent.eOnMainMenu, smMainMenu);
            states[6] = new StateConnection(smGame, StateMachine.smEvent.eOnPause, smPause);
            states[7] = new StateConnection(smGame, StateMachine.smEvent.eGameComplete, smGameComplete);
            states[8] = new StateConnection(smGame, StateMachine.smEvent.eGameOver, smGameOver);
            states[9] = new StateConnection(smGameComplete, StateMachine.smEvent.eOnMainMenu, smMainMenu);
            states[10] = new StateConnection(smGameOver, StateMachine.smEvent.eOnMainMenu, smMainMenu);
            states[11] = new StateConnection(smMainMenu, StateMachine.smEvent.eOnGame, smGame);
            // set states table and start first state
            StateMachine.SetStates(states);
        }
    }
}
