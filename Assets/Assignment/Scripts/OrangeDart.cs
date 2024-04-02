using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeDart : Dart
{
    // Start is called before the first frame update
    void Start()
    {
        starting();
    }

    // Update is called once per frame
    void Update()
    {
        Movement(0.01f);
    }

    protected override void Movement(float Speed)
    {

        Vector2 Speed2 = (Vector2)transform.position - Player.PlayerSpot;
        float newSpeed = (Mathf.Abs(Speed2.x) + Mathf.Abs(Speed2.y))/250;
        base.Movement(newSpeed);
    }
}
