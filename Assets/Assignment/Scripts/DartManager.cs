using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DartManager : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Orange;
    public GameObject Purple;
    public static float amountOfObjects;

    // Start is called before the first frame update
    // Update is called once per frame
    void Start()
    {
        amountOfObjects = 0.01f;
        StartCoroutine(Spawner());
    }

    private void Update()
    {
        if (Player.KillSwitch == true)
        {
            amountOfObjects = 0.01f;
        }
    }
    IEnumerator Spawner()
    {
        while (1 == 1)
        {
            int ran = Random.Range(1, 8);
            if (ran == 1)
            {
                amountOfObjects += 1;
                Instantiate(Blue);
            }
            if (ran == 2 || ran == 3)
            {
                amountOfObjects += 1;
                Instantiate(Orange);
            }
            if (ran > 3)
            {
                amountOfObjects += 1;
                Instantiate(Purple);
            }
            yield return new WaitForSeconds(timeToWait(amountOfObjects));
        }
    }

    static float timeToWait(float x)
    {
        x = Mathf.Log(x, 10);
        if (x <= 0)
        {
            return 0.01f;
        }
        return x;
    }
}
