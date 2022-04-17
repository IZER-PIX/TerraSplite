using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform ChildrenPortal;

    private void OnTriggerEnter2D(Collider2D col)
    {
        col.transform.position = ChildrenPortal.position;
    }

    /*
        Короче выходишь из портала, булл становиться тру, когда вошёл в портал бул становится фолз




    */
}
