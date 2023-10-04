using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState { Start, PTurn, ETurn, Win, Loss }
public class BattlerSystem : MonoBehaviour
{

    public GameObject playerprefab;
    public GameObject enemyprefab;
    public Transform playerpos;
    public Transform enemypos;

    Unit playerUnit;
    Unit enemyUnit;

    public TextMeshProUGUI Atkbut;
    public TextMeshProUGUI dialogueText;
    public BTLHuD pHuD;
    public BTLHuD eHuD;
    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.Start;
        StartCoroutine(SetupBTL());
    }

    // Update is called once per frame
    IEnumerator SetupBTL()
    {
        GameObject playerGO = Instantiate(playerprefab, playerpos);
        playerUnit = playerGO.GetComponent<Unit>();
        GameObject enemyGO = Instantiate(enemyprefab, enemypos);
        enemyUnit = enemyGO.GetComponent<Unit>();

        dialogueText.text = "You've been cornered by a" + " " + enemyUnit.UnitName + "...";

        pHuD.SetHuD(playerUnit);
        eHuD.SetHuD(enemyUnit);
        yield return new WaitForSeconds(2f);
        state = BattleState.PTurn;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool IsDead = enemyUnit.TakeDamage(playerUnit.Damage);
        eHuD.SetHP(enemyUnit.CurrentHP);
        dialogueText.text = playerUnit.UnitName + " Attacked for " + playerUnit.Damage + " HP!";
        yield return new WaitForSeconds(2f);
        if (IsDead)
        {
            state = BattleState.Win;
            EndBattle();
        }
        else
        {
            state = BattleState.ETurn;
            StartCoroutine(ETurn());
        }
    }

    IEnumerator ETurn()
    {
        dialogueText.text = enemyUnit.UnitName + " makes their move!";
        yield return new WaitForSeconds(1f);
        bool IsDead = playerUnit.TakeDamage(enemyUnit.Damage);
        pHuD.SetHP(playerUnit.CurrentHP);
        yield return new WaitForSeconds(1f);
        if (IsDead)
        {
           state = BattleState.Loss;
        }
        else
        {
            state = BattleState.PTurn;
            PlayerTurn();
        }
    }
    void EndBattle()
    {
        if (state == BattleState.Win)
        {
            dialogueText.text = "You Survived!";
        }
        else if (state == BattleState.Loss)
        {
            dialogueText.text = "You've lost your life...";
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = playerUnit.UnitName + " is ready,\n" + "Please select a command... ";
        if (Atkbut)
        {
            StartCoroutine(PlayerAttack());
        }
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PTurn)
        {
            return;
        }
        StartCoroutine(PlayerAttack());
    }


}