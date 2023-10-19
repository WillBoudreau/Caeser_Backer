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
        playerUnit.maxHP = PlayerData.CBmHP;
        playerUnit.currentHP = PlayerData.CBcHP;
        playerUnit.unitLevel = PlayerData.CBLVL;
        playerUnit.MnDamage = PlayerData.CBmnDMG;
        playerUnit.MxDamage = PlayerData.CBmxDMG;

        dialogueText.text = "You've been cornered by a " + enemyUnit.unitName + "...";
        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);
        yield return new WaitForSeconds(2f);
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }
    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.MnDamage, playerUnit.MxDamage);
        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = playerUnit.unitName + " Attacks!";
        yield return new WaitForSeconds(2f);
        dialogueText.text = playerUnit.unitName + " Deals " + PlayerData.RNGRSLT + " to the " + enemyUnit.unitName + "...";
        yield return new WaitForSeconds(2f);
        if (isDead)
        {

            dialogueText.text = "The " + enemyUnit.unitName + ", has been defeated...";
            state = BattleState.WON;
            StartCoroutine(EndBattle());
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
        yield return new WaitForSeconds(2f);
        bool isDead = playerUnit.TakeDamage(enemyUnit.MnDamage, enemyUnit.MxDamage);
        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "The " + enemyUnit.unitName + " deals " + PlayerData.RNGRSLT + " to " + playerUnit.unitName + "...";
        yield return new WaitForSeconds(2f);
        if (isDead)
        {

            state = BattleState.LOST;
            StartCoroutine(EndBattle());
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }
    IEnumerator EndBattle()
    {
        PlayerData.CBcHP = playerUnit.currentHP;



        PlayerData.CBXP = PlayerData.CBXP + enemyUnit.UnitXp;


        if (state == BattleState.WON)
        {
            dialogueText.text = "You've Survived...";
            yield return new WaitForSeconds(2f);
            dialogueText.text = "You gained " + enemyUnit.UnitXp + " XP!";
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(3);
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
        else
        {
            Skullivan.SetActive(false);
        }
        dialogueText.text = "Please select an Action:";
        BattleUI00.SetActive(true);
        BattleUI01.SetActive(true);
        BattleUI02.SetActive(true);
        BattleUI03.SetActive(true);
        FrTrn = true;
    }
    IEnumerator PlayerHeal()
    {
        dialogueText.text = "You apply bandages to your wounds...";
        yield return new WaitForSeconds(2f);
        int HealValue = UnityEngine.Random.Range(5, playerUnit.maxHP);
        playerUnit.Heal(HealValue);
        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = playerUnit.name + " Recovers " + HealValue + " Health!";
        yield return new WaitForSeconds(2f);
        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }
    IEnumerator Pray()
    {
        dialogueText.text = "You pray to the Six Gods...";
        int PrayValue = UnityEngine.Random.Range(0, 1000);
        yield return new WaitForSeconds(2);
        if (PrayValue == 777)
        {
            dialogueText.text = "The Six Gods Grant you a divine Blessing!";
            playerUnit.currentHP = playerUnit.maxHP;
            playerUnit.MnDamage += 500;
            playerUnit.MxDamage += 1000;
            PlayerData.CBXP += 100;
            yield return new WaitForSeconds(2);
        }
        else if (PrayValue >= 0 && PrayValue <= 50)
        {
            dialogueText.text = "They said some hurtful words...";
            yield return new WaitForSeconds(2);
            playerUnit.currentHP -= 25;
            if (playerUnit.currentHP <= 0)
            {
                playerUnit.currentHP = 0;
                state = BattleState.LOST;
                StartCoroutine(EndBattle());

            }
        }
        else if (PrayValue >= 51 && PrayValue <= 500)
        {
            dialogueText.text = "Nothing happens...";
            yield return new WaitForSeconds(2);
            //nothing
        }
        else if (PrayValue >= 501 && PrayValue <= 776)
        {
            dialogueText.text = "Your wounds have been healed!";
            yield return new WaitForSeconds(2);
            playerUnit.currentHP += 25;
            if (playerUnit.currentHP > playerUnit.maxHP)
            {
                playerUnit.currentHP = playerUnit.maxHP;
            }
        }
        else if (PrayValue >= 778 && PrayValue <= 1000)
        {
            dialogueText.text = "The Six Gods have blessed you with greed!";
            yield return new WaitForSeconds(2);
            enemyUnit.UnitXp *= 2;
        }
        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }
    IEnumerator FleeAttempt()
    {
        dialogueText.text = "You Attempt to Flee...";
        yield return new WaitForSeconds(2);
        int FleeValue = UnityEngine.Random.Range(0, 100);
        if (FleeValue >= 40 && FleeValue <= 60)
        {
            dialogueText.text = "You Flee.";
            yield return new WaitForSeconds(2);
            
            
            SceneManager.LoadScene(2);
        }
        else
        {
            dialogueText.text = "The " + enemyUnit.unitName + " Caught you!";
            yield return new WaitForSeconds(2);
            playerUnit.TakeDamage(enemyUnit.MnDamage, enemyUnit.MnDamage);
            dialogueText.text = playerUnit.unitName + " takes " + enemyUnit.MnDamage;
            yield return new WaitForSeconds(2);
            StartCoroutine(EnemyTurn());
        }
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
    public void OnRunButton()
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
        StartCoroutine(FleeAttempt());
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
    public void OnPrayButton()
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
            StartCoroutine(Pray());
        }
    }
}