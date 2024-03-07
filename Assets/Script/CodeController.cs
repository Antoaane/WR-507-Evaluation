using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeController : MonoBehaviour
{
    [SerializeField] private TMP_Text MagentaCodeText;
    [SerializeField] private TMP_Text OrangeCodeText;
    [SerializeField] private TMP_Text GreenCodeText;
    [SerializeField] private TMP_Text MagentaNumberText;
    [SerializeField] private TMP_Text OrangeNumberText;
    [SerializeField] private TMP_Text GreenNumberText;
    [SerializeField] private GameObject padlock;
    [SerializeField] private GameManager GameManager;

    private int MagentaCode;
    private int GreenCode;
    private int OrangeCode;
    private int MagentaNumber;
    private int GreenNumber;
    private int OrangeNumber;

    void Start()
    {
        MagentaCode = 0;
        GreenCode = 0;
        OrangeCode = 0;
        MagentaNumber = Random.Range(0, 9);
        GreenNumber = Random.Range(0, 9);
        OrangeNumber = Random.Range(0, 9);
        MagentaNumberText.text = MagentaNumber.ToString();
        GreenNumberText.text = GreenNumber.ToString();
        OrangeNumberText.text = OrangeNumber.ToString();
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
            GameManager.unlockWinDoor();
            GameManager.setCompleteCode(true);
            padlock.SetActive(false);
        }
        else
        {
            GameManager.lockWinDoor();
            GameManager.setCompleteCode(false);
            padlock.SetActive(true);
        }
    }
}
