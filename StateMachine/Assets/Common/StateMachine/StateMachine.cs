using UnityEngine;
using System.Collections;
using System.Linq;

public class StateMachine{
   
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

    public static void SetEvent(string sEvent) {
        StateConnection connection = scTable.SingleOrDefault(c =>  c.fromState == curState && c.smEvent == sEvent );
        if(connection != null) {
            eOnStopState(curState.tag);
            curState.StopState();
            curState = connection.toState;
            eOnStartState(curState.tag);
            curState.StartState();
        }
    }
}
