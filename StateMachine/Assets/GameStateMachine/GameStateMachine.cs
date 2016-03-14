using UnityEngine;
using System.Collections;

public class GameStateMachine : MonoBehaviour {
    public static GameStateMachine instance;
    //FSM events
    public static string eOnOption = "eOnOption";
    public static string eOnMainMenu = "eOnMainMenu";
    public static string eOnPause = "eOnPause";
    public static string eOnGame = "eOnGame";
    public static string eGameComplete = "eGameComplete";
    public static string eGameOver = "eGameOver";
    //FSM States
    SMStateGame         smGame;
    SMStateGameComplete smGameComplete;
    SMStateGameOver     smGameOver;
    SMStateMainMenu     smMainMenu;
    SMStateOptions      smOptions;
    SMStatePause        smPause;

    const int SMCountConnections = 12;
    StateConnection[] states;
 
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
            states[0] = new StateConnection(smMainMenu,eOnOption, smOptions);
            states[1] = new StateConnection(smOptions, eOnMainMenu, smMainMenu);
            states[2] = new StateConnection(smOptions, eOnPause, smPause);
            states[3] = new StateConnection(smPause, eOnOption, smOptions);
            states[4] = new StateConnection(smPause, eOnGame, smGame);
            states[5] = new StateConnection(smPause, eOnMainMenu, smMainMenu);
            states[6] = new StateConnection(smGame, eOnPause, smPause);
            states[7] = new StateConnection(smGame, eGameComplete, smGameComplete);
            states[8] = new StateConnection(smGame, eGameOver, smGameOver);
            states[9] = new StateConnection(smGameComplete, eOnMainMenu, smMainMenu);
            states[10] = new StateConnection(smGameOver, eOnMainMenu, smMainMenu);
            states[11] = new StateConnection(smMainMenu, eOnGame, smGame);
            // set states table and start first state
            StateMachine.SetStates(states);
        }
    }
}
