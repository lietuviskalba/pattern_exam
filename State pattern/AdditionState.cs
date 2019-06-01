using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionState : MonoBehaviour, IState
{
    // *** STATE PATTERN ***
    // The concrete implementation for the state pattern

    int num1;
    int num2;
    int ans;

    public string Operation(GameLogic gl)
    {
      
        num1 = Random.Range(1, 6);
        num2 = Random.Range(1, 6);

        SetAns(num1, num2);

        gl.SetState(this);

        return  num1 + "+" + num2;
    }

    public void SetAns(int n1, int n2)
    {
        ans = n1 + n2;
    }

    public int GetAns()
    {
        return ans;
    }
}
