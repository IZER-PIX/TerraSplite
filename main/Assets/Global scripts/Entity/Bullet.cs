using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class Bullet : Entity
{
    public bool Contact = false;
    public ContactPoint2D ContactedObject;
    public float DeathTime = 3f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts.Length > 0)
        {
            Contact = true;
            ContactedObject = collision.contacts[0];
        }
        else
            ContactedObject = new ContactPoint2D();

        Destroy(gameObject);
    }
    private IEnumerator Death(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
