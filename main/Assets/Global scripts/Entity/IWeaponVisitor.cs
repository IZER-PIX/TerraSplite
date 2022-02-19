using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponVisitor
{
    public void Visitor(Sword weapon);
    public void Visitor(Gun weapon, RaycastHit hit);
    public void Visitor(MagicBall weapon, RaycastHit hit);
}
