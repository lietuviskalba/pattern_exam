using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullItem : AbstractItem
{
    // *** NULLOBECT PATTERN ***
    // Create an concrete class for objects that might go bad to have a default null behaviour

    public override GameObject CreateItem()
    {
        return new GameObject();
    }

    public override string GetCreator()
    {
        Debug.LogError("Something went wrong");
        return "Null made object.";
    }
}
