using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponVisitor
{
    public void Visit(Sword weapon);
    public void Visit(Gun weapon, ContactPoint2D hit);
}
