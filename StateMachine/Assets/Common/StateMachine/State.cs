using UnityEngine;
using System.Collections;

public class State{
    public virtual void StartState() { }
    public virtual void StopState() { }
    public string tag;
}
