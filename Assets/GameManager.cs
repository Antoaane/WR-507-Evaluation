using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text HintText;
    [SerializeField] private TMP_Text MagentaCodeText;
    [SerializeField] private TMP_Text OrangeCodeText;
    [SerializeField] private TMP_Text GreenCodeText;
    [SerializeField] private TMP_Text MagentaNumberText;
    [SerializeField] private TMP_Text OrangeNumberText;
    [SerializeField] private TMP_Text GreenNumberText;
    [SerializeField] private List<string> hintList;
    [SerializeField] private XRGrabInteractable winDoorGrab;
    [SerializeField] private XRGrabInteractable hintDoorGrab;
    [SerializeField] private XRGrabInteractable otherDoorGrab;
    [SerializeField] private GameObject padlock;
    private int MagentaCode;
    private int GreenCode;
    private int OrangeCode;
    private int MagentaNumber;
    private int GreenNumber;
    private int OrangeNumber;
    private bool CodeCompleted;

    void Start()
    {
        if (hintList == null || hintList.Count == 0)
        {
            hintList = new List<string>(4)
            {
                "Il fait sombre...",
                "Mais où je l'ai laissé trainer déjà ?",
                "Hop, dans l'ordinateur !",
                "Ho les écrans se sont allumés !",
            };
        }
        ShowHint(0);
        winDoorGrab.enabled = false;
        hintDoorGrab.enabled = false;
        otherDoorGrab.enabled = false;
        MagentaCode = 0;
        GreenCode = 0;
        OrangeCode = 0;
        MagentaNumber = Random.Range(0, 9);
        GreenNumber = Random.Range(0, 9);
        OrangeNumber = Random.Range(0, 9);
        MagentaNumberText.text = MagentaNumber.ToString();
        GreenNumberText.text = GreenNumber.ToString();
        OrangeNumberText.text = OrangeNumber.ToString();
        CodeCompleted = false;
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

    public void unlockWinDoor()
    {
        winDoorGrab.enabled = true;
    }

    public void unlockOtherDoor()
    {
        hintDoorGrab.enabled = true;
        otherDoorGrab.enabled = true;
    }

    public void incrementMagentaCode()
    {
        MagentaCode = MagentaCode + 1;
        if (MagentaCode >= 10)
        {
            MagentaCode = 0;
        }
        MagentaCodeText.text = MagentaCode.ToString();
        verifyCode();
    }

    public void incrementOrangeCode()
    {
        OrangeCode = OrangeCode + 1;
        if (OrangeCode >= 10)
        {
            OrangeCode = 0;
        }
        OrangeCodeText.text = OrangeCode.ToString();
        verifyCode();
    }

    public void incrementGreenCode()
    {
        GreenCode = GreenCode + 1;
        if (GreenCode >= 10)
        {
            GreenCode = 0;
        }
        GreenCodeText.text = GreenCode.ToString();
        verifyCode();
    }

    private void verifyCode()
    {
        if (MagentaCode == MagentaNumber && OrangeCode == OrangeNumber && GreenCode == GreenNumber)
        {
            unlockWinDoor();
            CodeCompleted = true;
            padlock.SetActive(false);
        }
    }

    public bool isCodeCompleted()
    {
        return CodeCompleted;
    }
}
