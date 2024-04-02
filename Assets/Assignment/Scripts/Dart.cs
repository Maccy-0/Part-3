using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Dart : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Movement(0.01f);
    }

    protected void starting()
    {
        int ran = Random.Range(1, 5);
        if (ran == 1)
        {
            transform.position = new Vector2(-12, Random.Range(-6, 6));
        }
        if (ran == 2)
        {
            transform.position = new Vector2(12, Random.Range(-6, 6));
        }
        if (ran == 3 || ran == 4)
        {
            transform.position = new Vector2(Random.Range(-12, 12), 6);
        }
    }
    protected virtual void Movement(float Speed)
    {
        Debug.Log(Player.PlayerSpot);
        Vector3 diff = Player.PlayerSpot - (Vector2)transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        transform.position = Vector2.MoveTowards(transform.position, Player.PlayerSpot, Speed);
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PlayerHurt");
    }
}
