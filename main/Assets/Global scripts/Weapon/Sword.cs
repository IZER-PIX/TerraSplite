using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : WeaponOverlap
{
    public override void Attack()
    {
        base.Attack();
    }

    protected override IEnumerator AttackDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        AllowShooting = true;
    }

    public override void Accept(IWeaponVisitor visitor)
    {
        visitor?.Visit(this);
    }
}
