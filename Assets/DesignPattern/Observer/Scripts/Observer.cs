using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    // 옵저버에 대한 추상 클래스
    // 옵저버들이 구현해야할 기능들이 들어있음.(인터페이스와 유사)

    public abstract void OnNotify(int number);
}
