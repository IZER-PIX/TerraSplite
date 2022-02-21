using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : WeaponRaycast
{
	protected override void Attack(){
		AllowShooting = false;
		SpendAmmo(1);

		//TODO: сделать задержку на пол секунды. Можно использовать UniTask
		AllowShooting = true;
	}

    protected override void Accept(IWeaponVisitor visitor, RaycastHit hit)
    {
    	visitor?.Visit(this, hit);
    }
}
