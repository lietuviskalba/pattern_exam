using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractItem : MonoBehaviour
{
    // *** NULLOBECT PATTERN ***
    // Create an abstract class for objects that are going to be used

    public abstract string GetCreator();
    public abstract GameObject CreateItem(); 
}
