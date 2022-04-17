using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : WeaponOverlap
{
    public override void Attack()
    {
        if(AllowShooting)
        {
            AllowShooting = false;

            base.Attack();

            StartCoroutine(AttackDelay(AttackTimeDelay));
        }
        return;
    }

    protected override IEnumerator AttackDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }

    public override void Accept(IWeaponVisitor visitor){}
}
