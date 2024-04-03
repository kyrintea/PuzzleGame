using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalHit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            print("Goal hit!");
            //switch scene
            //make things prefabs so you can edit between scenes more easily
        }
    }
}
