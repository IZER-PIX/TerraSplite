using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : WeaponRaycast
{
	protected override void Attack(){
		if(AllowShooting){
			StartCoroutine(AttackDelay(AttackTimeDelay));
			AllowShooting = false;
		}
		return;
	}

	protected override IEnumerator AttackDelay(float delay){
		base.Attack();
		SpendAmmo(1);

		yield return new WaitForSeconds(delay);
		AllowShooting = true;
	}

    protected override void Accept(IWeaponVisitor visitor, RaycastHit2D hit)
    {
    	visitor?.Visit(this, hit);
    }

}
