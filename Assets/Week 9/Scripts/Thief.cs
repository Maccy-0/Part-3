using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    
    public GameObject daggerPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    float time = 0;


    protected override void Attack()
    {
        base.Attack();
        Instantiate(daggerPrefab, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);
        speed = 15;
    }

    protected override void Update()
    {
        base.Update();
        if (time > 0.3)
        {
            speed = 3;
            time = 0;
        }
        if (speed > 3)
        {
            time += Time.deltaTime;
        }
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

}
