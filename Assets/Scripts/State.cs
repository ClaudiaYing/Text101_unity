using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)][SerializeField] string stroyText;
    [SerializeField] State[] nextStates;


    public string GetStateStory()
    {
        return stroyText;
    }

    public State[] GetNextState()
    {
        return nextStates;
    }
   
}
