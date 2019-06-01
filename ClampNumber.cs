using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClampNumber : MonoBehaviour
{
    public Text numLable;

    private void Start()
    {
        numLable.transform.position = transform.position;
    }

    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        numLable.transform.position = namePose;
    }
}
