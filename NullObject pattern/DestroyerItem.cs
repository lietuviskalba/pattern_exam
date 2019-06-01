using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerItem : AbstractItem
{
    // *** NULLOBECT PATTERN ***
    // Create an concrete implementation for the real class your going to use

    public override GameObject CreateItem()
    {
        GameObject destItem = GameObject.CreatePrimitive(PrimitiveType.Cube);
        destItem.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        destItem.transform.position = new Vector3(0, -10, 0);
        destItem.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        destItem.name = "Dest Item";
        Rigidbody rb = destItem.AddComponent<Rigidbody>();
        rb.mass = 0.00001f;
        rb.angularDrag = 10f;
        rb.drag = 5f;
        BoxCollider dibc = destItem.AddComponent<BoxCollider>();
        dibc.isTrigger = true;
        destItem.tag = "Death";

        return destItem;
    }

    public override string GetCreator()
    {
        return "Normal creation";
    }
}
