using UnityEngine;

public class Korean : ILanguage
{
    public ChangeLanguage context;

    public Korean(ChangeLanguage context)
    {
        this.context = context;
    }

    public void SelectLanguage()
    {
        Debug.Log("Applying Korean language...");
        context.text.text = "언어 : 한국어 \n 플레이어 이름 : 연장 \n 플레이어 레벨 : 1";
    }
}