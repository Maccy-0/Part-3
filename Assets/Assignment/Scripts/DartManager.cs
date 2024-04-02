using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DartManager : MonoBehaviour
{
    public GameObject Blue;
    public GameObject Orange;
    public GameObject Purple;

    // Start is called before the first frame update
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        while (1 == 1)
        {
            int ran = Random.Range(1, 8);
            if (ran == 1)
            {
                Instantiate(Blue);
            }
            if (ran == 2 || ran == 3)
            {
                Instantiate(Orange);
            }
            if (ran > 3)
            {
                Instantiate(Purple);
            }
            yield return new WaitForSeconds(1f);
            //Test
        }
    }
}
