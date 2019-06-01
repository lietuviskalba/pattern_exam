using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apple : MonoBehaviour
{
    public Text txtUniqueNum;

    Subject sub = new Subject();
    
    float maxSpeed = 6f;
    float fallSpeed;

    Vector3 startPos;

    public int uniqueNum;
    public bool hasNewWaveEnded = false;

    public static int appleCount;

    private void Start()
    {
        AppleUniqueNumber();

        startPos = this.transform.position;

        new ApplesLandObserver(sub);

        TweakParamaters();
    }

    private void AppleUniqueNumber()
    {
        uniqueNum = Random.Range(-5, 6);
        txtUniqueNum.text = uniqueNum.ToString();
    }

    public void TweakParamaters()
    {
        transform.position = startPos;
        fallSpeed = Random.Range(5f, maxSpeed);
    }

    public void ApplesFall()
    {
        hasNewWaveEnded = false;
    }

    void Update()
    {
        if (!hasNewWaveEnded)
        {
            this.transform.position += Vector3.down * fallSpeed * Time.deltaTime; 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TweakParamaters();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            AppleActivation(false);
        }

        if (other.gameObject.tag.Equals("Shredder"))
        {

            AppleActivation(false);
        }
    }

    private void AppleActivation(bool state)
    {
        // *** OBSERVER PATTERN ***
        // Used here to notify about all apples have fallen and need a reset

        sub.SetState(1);

        TweakParamaters();
        hasNewWaveEnded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        AppleUniqueNumber();
    }
}
