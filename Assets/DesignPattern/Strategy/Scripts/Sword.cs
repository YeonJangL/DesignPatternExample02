using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("This is Sword");
    }

    public void Attack(GameObject obj)
    {
        Vector3 v3 = new Vector3(transform.position.x, transform.position.y, 0);

        var bullet = Instantiate(obj);
        bullet.transform.position = v3;
    }
}
