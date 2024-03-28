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

    // 변경 버튼을 클릭했을 때 선택한 언어를 적용
    public void ApplyLanguage()
    {
        switch (selected_language)
        {
            case LanguageType.English:
                text.text = "Language : English \n PlayerName : YeonJang \n PlayerLv : 1";
                break;
            case LanguageType.Korean:
                text.text = "언어 : 한국어 \n 플레이어 이름 : 연장 \n 플레이어 레벨 : 1";
                break;
        }
    }
}