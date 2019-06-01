using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterGame : MonoBehaviour
{
    public Text txtOperation;

    GameObject[] apples;

    GameLogic gl = new GameLogic();
    AdditionState adds = new AdditionState();
    SubtractionState subs = new SubtractionState();

    public static int equationAns;

    public static int appleCount;

    void Start()
    {
        apples = GameObject.FindGameObjectsWithTag("Apple"); // Find all apple game objects

        ChangeOperationRand();
    } 

    private void ChangeOperationRand()
    {
        string currOperation;

        int randState = Random.Range(1, 3);

        // *** STATE PATTERN ***
        // Invokation use for the state pattern

        switch (randState)
        {
            case 1:
                currOperation = adds.Operation(gl);
                equationAns = adds.GetAns();
                break;
            case 2:
                currOperation = subs.Operation(gl);
                equationAns = subs.GetAns();
                break;
            default:
                currOperation = "ERR";
                break;
        }

        txtOperation.text = currOperation; // Display score in game
    }

    void Update()
    {
        ResetAppleFallOnceFallen();
    }

    private void ResetAppleFallOnceFallen()
    {
        if (appleCount >= 4) // Check if all 4 apples fell
        {
            foreach (GameObject app in apples)
            {
                app.GetComponent<Apple>().ApplesFall(); // Reset the fall paramter for each apple individualy
            }
            ChangeOperationRand();
            appleCount = 0; // Reset the count
        }
    }
}
