using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    protected override void Attack()
    {
        //dash towards mouse
        StopCoroutine("Dash");
        StartCoroutine("Dash");
        //base.Attack();
    }
        
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        yield return new WaitForSeconds(0.5f);
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(0.16f);
        Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
        yield break;
    }
}
