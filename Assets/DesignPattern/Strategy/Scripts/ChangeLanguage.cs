using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum LanguageType
{
    English, Korean
}

public class ChangeLanguage : MonoBehaviour
{
    public Button eg;
    public Button kr;
    public Button change;
    public Text text;

    private LanguageType selected_language;

    private void Start()
    {
        selected_language = LanguageType.Korean;

        ApplyLanguage();
    }
        
    public void ChangeEg()
    {
        selected_language = LanguageType.English;
    }

    public void ChangeKr()
    {
        selected_language = LanguageType.Korean;
    }

    // ���� ��ư�� Ŭ������ �� ������ �� ����
    public void ApplyLanguage()
    {
        switch (selected_language)
        {
            case LanguageType.English:
                text.text = "Language : English \n PlayerName : YeonJang \n PlayerLv : 1";
                break;
            case LanguageType.Korean:
                text.text = "��� : �ѱ��� \n �÷��̾� �̸� : ���� \n �÷��̾� ���� : 1";
                break;
        }
    }
}