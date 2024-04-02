using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    Coroutine coroutine;
    int mouseState = 0;
    float speed = 5;
    Rigidbody2D RB;
    public static Vector2 PlayerSpot;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerSpot = transform.position;
        if (Input.GetMouseButtonDown(0) && mouseState == 0)
        {
            mouseState = 1;
        }
        if (Input.GetMouseButtonUp(0) && mouseState == 1)
        {
            if (coroutine != null)
            {
                StopCoroutine(coroutine);
            }
            coroutine = StartCoroutine(Movement(Input.mousePosition));
            mouseState = 0;
        }
    }

    IEnumerator Movement(Vector2 point)
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(point) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        float timer = 0;
        
        while (timer < 30)
        {
            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(point), -0.01f);
            timer += 1;
            yield return null;
            Debug.Log(point);
        }

        while (timer < 200)
        {
            transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(point), 0.05f);
            timer += 1;
            yield return null;
            Debug.Log(point);
        }


        yield return null;
    }
}
