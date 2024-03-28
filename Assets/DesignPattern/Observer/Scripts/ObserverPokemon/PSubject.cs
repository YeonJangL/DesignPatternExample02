using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PSubject
{
    void Register(PObserver observer);

    void Remove(PObserver observer);

    void Notify();
}