using UnityEngine;
using System.Collections;

public class StateConnection{
    public State fromState;
    public StateMachine.smEvent smEvent;
    public State toState;

    public StateConnection(State fromState, StateMachine.smEvent smEvent, State toState) {
        this.fromState = fromState;
        this.smEvent = smEvent;
        this.toState = toState;
    }

}
