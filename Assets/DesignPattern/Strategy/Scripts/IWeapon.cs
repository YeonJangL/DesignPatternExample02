using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Attack(); // 디버그용
    void Attack(GameObject obj); // 실제 공격용
}
