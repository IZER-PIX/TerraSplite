using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float ShellSpeed;
    public Bullet Shell;
    public Transform WeaponPoint;

    private void Update()
    {

    }

    public Bullet Shoot()
    {
        Bullet bullet = Instantiate(Shell, WeaponPoint.position, WeaponPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(WeaponPoint.right * ShellSpeed, ForceMode2D.Impulse);

        return bullet;
    }
}
