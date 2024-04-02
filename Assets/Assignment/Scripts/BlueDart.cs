using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BlueDart : Dart
{
    // Start is called before the first frame update
    void Start()
    {
        starting();
    }

    // Update is called once per frame
    void Update()
    {
        Kill();
        Movement(0.01f);
        Spin();
    }

    protected override void Movement(float Speed)
    {
        Vector2 spot = new Vector2(Random.Range(-12,13), Random.Range(-6,6));
        transform.position = Vector2.MoveTowards(transform.position, spot, 0.2f);
    }

    void Spin()
    {
        transform.Rotate(0f, 0f, 3f, Space.Self);
    }
}
