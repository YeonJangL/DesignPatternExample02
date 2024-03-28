using UnityEngine;

public class English : ILanguage
{
    public ChangeLanguage context;

    public English(ChangeLanguage context)
    {
        this.context = context;
    }

    public void SelectLanguage()
    {
        Debug.Log("Applying English language...");
        context.text.text = "Language : English \n PlayerName : YeonJang \n PlayerLv : 1";
    }
}