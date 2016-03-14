using UnityEngine;
using System.Collections;

public class StateConnection{
    public State fromState;
    public string smEvent;
    public State toState;

    public StateConnection(State fromState, string smEvent, State toState) {
        this.fromState = fromState;
        this.smEvent = smEvent;
        this.toState = toState;
    }

}
