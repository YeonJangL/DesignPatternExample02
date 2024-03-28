using UnityEngine;
using UnityEngine.UI;

public class HP_PObserver : MonoBehaviour, PObserver
{
    public Slider myHPSlider;
    public Slider enemyHPSlider;
    public Image myImage;
    public Image enemyImage;
    public Image enemyImagedie;

    private HP_PSubject hpSubject;

    private void Start()
    {
        hpSubject = FindObjectOfType<HP_PSubject>();
        if (hpSubject !=  null)
        {
            hpSubject.Register(this);
        }
    }

    private void OnDestroy()
    {
        if(hpSubject != null)
        {
            hpSubject.Remove(this);
        }
    }

    public void PObserverUpdate(float myHP, float enemyHP)
    {
        myHPSlider.value = myHP;
        enemyHPSlider.value = enemyHP;

        if (enemyHP == 0)
        {
            enemyImage.gameObject.SetActive(false);
            enemyImagedie.gameObject.SetActive(true);
        }
        if (myHP == 0)
        {
            myImage.gameObject.SetActive(false);
        }
    }
}