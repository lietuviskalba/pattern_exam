using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    // *** STATE PATTERN ***
    // interface for changing various states

    string Operation(GameLogic gl);
    void SetAns(int num1, int num2);
    int GetAns();
}
