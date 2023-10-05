using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public GameObject BattleUI00;
    public GameObject BattleUI01;
    public GameObject BattleUI02;
    public GameObject BattleUI03;
    public GameObject Skullivan;
    public Transform playerBattleStation;
    public Transform enemyBattleStation;
    bool FrTrn;
    Unit playerUnit;
    Unit enemyUnit;
    public TextMeshProUGUI dialogueText;
    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;
    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        BattleUI00.SetActive(false);
        BattleUI01.SetActive(false);
        BattleUI02.SetActive(false);
        BattleUI03.SetActive(false);
        Skullivan.SetActive(false);
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }
    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();
        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Unit>();
        dialogueText.text = "You've been cornered by a " + enemyUnit.unitName + "...";
        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);
        yield return new WaitForSeconds(2f);
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }
    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = playerUnit.unitName + " Attacks!";
        yield return new WaitForSeconds(1f);
        dialogueText.text = playerUnit.unitName + " Deals " + playerUnit.damage + " to the" + playerUnit.unitName + "...";
        yield return new WaitForSeconds(1f);
        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }
    IEnumerator EnemyTurn()
    {
        dialogueText.text = "The " + enemyUnit.unitName + " Makes their move!";
        yield return new WaitForSeconds(1f);
        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);
        playerHUD.SetHP(playerUnit.currentHP);       
        dialogueText.text = "The " + enemyUnit.unitName + " deals " + enemyUnit.damage + " to " + playerUnit.unitName + "...";
        yield return new WaitForSeconds(1f);
        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }
    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            dialogueText.text = "You've Survived...";
            SceneManager.LoadScene(4);
        }
        else if (state == BattleState.LOST)
        {
            dialogueText.text = "You've lost your life...";
            SceneManager.LoadScene(0);
        }
    }
    void PlayerTurn()
    {
        if (playerUnit.currentHP == 5 || playerUnit.currentHP <= 5)
        {
            Skullivan.SetActive(true);
        }       
        dialogueText.text = "Please select an Action:";
        BattleUI00.SetActive(true);
        //BattleUI01.SetActive(true);
        //BattleUI02.SetActive(true);
        BattleUI03.SetActive(true);
        FrTrn = true;
    }
    IEnumerator PlayerHeal()
    {
        dialogueText.text = "You Ask God for heals...";
        yield return new WaitForSeconds(1f);
        playerUnit.Heal(20);
        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "Your God heals you... Reluctantly...";
        yield return new WaitForSeconds(1f);
        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }
    public void OnAttackButton()
    {
        if (FrTrn)
        {
            FrTrn = false;
            BattleUI00.SetActive(false);
            BattleUI01.SetActive(false);
            BattleUI02.SetActive(false);
            BattleUI03.SetActive(false);
            if (state != BattleState.PLAYERTURN)
            {
                return;
            }
        }
        StartCoroutine(PlayerAttack());
    }
    public void OnHealButton()
    {
        FrTrn = true;
        if (FrTrn)
        {
            FrTrn = false;
            BattleUI00.SetActive(false);
            BattleUI01.SetActive(false);
            BattleUI02.SetActive(false);
            BattleUI03.SetActive(false);
            if (state != BattleState.PLAYERTURN)
            {
                return;
            }
        StartCoroutine(PlayerHeal());         
        }
    }
}
