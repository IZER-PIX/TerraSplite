using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : WeaponOverlap
{
    protected override IEnumerator AttackDelay(float delay){
        yield return new WaitForSeconds(delay);
    }

    public override void Accept(IWeaponVisitor visitor){}
}
