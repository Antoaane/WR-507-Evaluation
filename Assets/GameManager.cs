using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text HintText;
    [SerializeField] private List<string> hintList;
    void Start()
    {
        if (hintList == null || hintList.Count == 0)
        {
            hintList = new List<string>(4)
            {
                "Il fait sombre...",
                "Mais où je l'ai laissé trainée déjà ?",
                "Hop, dans l'ordinateur !",
                "Ho les écrans se sont allumés !",
            };
        }
        ShowHint(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void ShowHint(int level)
    {
        if (level < hintList.Count)
            HintText.text = hintList[level] + "\n";
        else
            HintText.text = "Déjà fini ? Recommence !\n";
    }
}
