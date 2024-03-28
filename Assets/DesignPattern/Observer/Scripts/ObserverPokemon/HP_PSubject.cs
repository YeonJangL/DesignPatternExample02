using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_PSubject : MonoBehaviour, PSubject
{
    private List<PObserver> m_PObservers = new List<PObserver>();

    public float m_HP;
    public float enemy_HP;

    public void SetHP(float M_HP, float E_HP)
    {
        m_HP = M_HP;
        enemy_HP = E_HP;
        Notify();
    }

    public void Notify()
    {
        foreach (var pokemon in m_PObservers)
        {
            pokemon.PObserverUpdate(m_HP, enemy_HP);
        }
    }

    public void Register(PObserver observer)
    {
        m_PObservers.Add(observer);
    }

    public void Remove(PObserver observer)
    {
        m_PObservers.Remove(observer);
    }
}