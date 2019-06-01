using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float minMaxMoveRestriction = 5;

    Subject sub = new Subject();

    private void Start()
    {
        new ScoreObserver(sub);
        new GameObserver(sub);
    }

    void FixedUpdate()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0, 0);

        RestrictMovement();
    }

    private void RestrictMovement()
    {
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minMaxMoveRestriction * (-1), minMaxMoveRestriction);
        transform.position = clampedPosition;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Apple"))
        {
            int appNum = other.gameObject.GetComponent<Apple>().uniqueNum;
            int EquaAns = MasterGame.equationAns;

            if (appNum == EquaAns)
            {
                // *** OBSERVER PATTERN ***
                // Give point on succeful problem solved
                sub.SetState(2);
            }
            else
            {
                // *** OBSERVER PATTERN ***
                // Game over if hit by wrong object

                sub.SetState(3);
            }
        }

        if (other.gameObject.tag.Equals("Death"))
        {
            sub.SetState(3);
        }
    }
}
