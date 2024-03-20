using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public Transform Part1;
    public Transform Part2;
    public Transform Part3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Build");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Build()
    {
        while (Part1.transform.position.y < 0)
        {
            Part1.transform.position = (Vector2)Part1.transform.position + new Vector2(0, 0.01f);
            yield return new WaitForEndOfFrame();
        }
        while (Part2.transform.position.y < 1.05)
        {
            Part2.transform.position = (Vector2)Part2.transform.position + new Vector2(0, 0.01f);
            yield return new WaitForEndOfFrame();
        }
        while (Part3.transform.position.y < 1.5)
        {
            Part3.transform.position = (Vector2)Part3.transform.position + new Vector2(0, 0.01f);
            yield return new WaitForEndOfFrame();
        }
        yield break;
    }
}
