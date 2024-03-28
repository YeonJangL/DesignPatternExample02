using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    private HP_PSubject hpSubject;

    public void Start()
    {
        button1.onClick.AddListener(attackbutton1);
        button2.onClick.AddListener(attackbutton2);
        button3.onClick.AddListener(attackbutton3);

        hpSubject = FindObjectOfType<HP_PSubject>();
    }

    public void attackbutton1()
    {
        float damage = 5.0f;
        AttackEnemy(damage);
    }

    public void attackbutton2()
    {
        float damage = 10.0f;
        AttackEnemy(damage);
    }

    public void attackbutton3()
    {
        float damage = 15.0f;
        AttackEnemy(damage);
    }

    private void AttackEnemy(float damage)
    {
        if (hpSubject != null)
        {
            float newEnemyHP = hpSubject.enemy_HP - damage;
            hpSubject.SetHP(hpSubject.m_HP, Mathf.Max(newEnemyHP, 0)); // 최소값은 0으로 설정
        }
    }
}