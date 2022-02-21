using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponOverlap : Weapon
{
    public void Attack(){}
    public abstract void Accept(IWeaponVisitor visitor);
}
