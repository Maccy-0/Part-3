using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleDart : Dart
{
    Vector2 endGoal;
    // Start is called before the first frame update
    void Start()
    {
        starting();
        int ran = Random.Range(1, 5);
        if (ran == 1)
        {
            endGoal = new Vector2(-13, Random.Range(-6, 6));
        }
        if (ran == 2)
        {
            endGoal = new Vector2(13, Random.Range(-6, 6));
        }
        if (ran == 3)
        {
            endGoal = new Vector2(Random.Range(-12, 12), 7);
        }
        if (ran == 4)
        {
            endGoal = new Vector2(Random.Range(-12, 12), -7);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Kill();
        Movement(0.02f);
        StartCoroutine(Size());
    }

    protected override void Movement(float Speed)
    {
        Debug.Log(Player.PlayerSpot);
        Vector3 diff = endGoal - (Vector2)transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        transform.position = Vector2.MoveTowards(transform.position, endGoal, Speed);
        if (endGoal == (Vector2)transform.position)
        {
            DartManager.amountOfObjects -= 1;
            Destroy(gameObject);
        }
    }

    IEnumerator Size()
    {
        while (1 == 1)
        {
            float size = 0;
            while (size < 2)
            {
                size += Time.deltaTime;
                Vector3 scale = new Vector3(size, size, size);
                transform.localScale = scale;
                yield return null;
            }
            while (size > 0.1)
            {
                size -= Time.deltaTime;
                Vector3 scale = new Vector3(size, size, size);
                transform.localScale = scale;
                yield return null;
            }
        }
    }
}
