using UnityEngine;
using System.Collections;

public class StateMachine{
   
    public enum smEvent { eOnMainMenu, eOnOption, eOnPause, eOnGame, eGameOver, eGameComplete };
    public delegate void dsme(string stateTag);
    public static event dsme eOnStartState = (string stateTag) => { };
    public static event dsme eOnStopState = (string stateTag) => { };

    static StateConnection[] scTable;
    static State curState;

    public static bool TablePresent() {
        return (scTable != null);
    }

    public static void SetStates(StateConnection[] scNewTable) {
        scTable = scNewTable;
        curState = scTable[0].fromState;
        eOnStartState(curState.tag);
        curState.StartState();
    }

    public static void SetEvent(smEvent sEvent) {
        foreach(StateConnection connection in scTable) {
            if(connection.fromState == curState && connection.smEvent == sEvent) {
                eOnStopState(curState.tag);
                curState.StopState();
                curState = connection.toState;
                eOnStartState(curState.tag);
                curState.StartState();
            }
        }
    }
}
