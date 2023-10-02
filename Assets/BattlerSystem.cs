using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { Start, PTurn, ETurn, Win, Loss }
public class BattlerSystem : MonoBehaviour
{

    public GameObject playerprefab;
    public GameObject enemyprefab;
    public Transform playerpos;
    public Transform enemypos;

    Unit playerUnit;
    Unit enemyUnit;

    public Text dialogueText;
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
        enemyUnit.TakeDamage(playerUnit.Damage);
        yield return new WaitForSeconds(2f);
    }

    void PlayerTurn()
    {
        dialogueText.text = playerUnit.UnitName + " is ready,\n" + "Please select a command... ";
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
