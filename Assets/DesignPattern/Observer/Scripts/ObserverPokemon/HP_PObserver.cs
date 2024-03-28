using UnityEngine;
using UnityEngine.UI;

public class HP_PObserver : MonoBehaviour, PObserver
{
    public Slider slider;

    public HP_PObserver(Slider slider)
    {
        this.slider = slider;
    }

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        // 체력바에 대한 정보
        float myvalue = slider.gameObject.GetComponent<HP_PSubject>().m_HP;
        float enemyvalue = slider.gameObject.GetComponent<HP_PSubject>().enemy_HP;
        Debug.Log("적 체력 : 100");
        Debug.Log("현재 체력 : 100");
    }
}