using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : WeaponRaycast
{
	public override void Attack(){
		if(AllowShooting){
			AllowShooting = false;

			base.Attack();
			SpendAmmo(1);

			StartCoroutine(AttackDelay(AttackTimeDelay));
		}
		return;
	}

	protected override IEnumerator AttackDelay(float delay){
		yield return new WaitForSeconds(delay);
		AllowShooting = true;
	}

    protected override void Accept(IWeaponVisitor visitor, ContactPoint2D hit)
    {
    	visitor?.Visit(this, hit);
    }

}
