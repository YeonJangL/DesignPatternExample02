using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector
{
    // 인터페이스 접속(접근점)
    private IWeapon iwp;

    // 무기 교체
    public void SetWeapon(IWeapon weapon)
    {
        iwp = weapon;
    }

    // 공격 기능
    public void Attack()
    {
        iwp.Attack();
    }
}
