using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    int playerTurn = 1;

    public Image playerTurn_banner;
    public List<Color> playerColorList;

    public TextMeshProUGUI playerTurn_txt;
    public List<string> playerTxtList;

    public void Awake()
    {
        ShowNextTurn();
    }

    public void NextTurn()
    {
        playerTurn++;
        if (playerTurn == 3) playerTurn = 1;

        ShowNextTurn();
    }

    public void ShowNextTurn()
    {
        playerTurn_txt.gameObject.SetActive(false);
        playerTurn_banner.color = playerColorList[playerTurn - 1];
        playerTurn_txt.text = playerTxtList[playerTurn - 1];
        playerTurn_txt.gameObject.SetActive(true);
    }
}
