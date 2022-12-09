using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystems : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject EnemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    Units playerUnit;
    Units enemyUnit;
    
    //public Text dialogueText;
    //for the dialogue box in battle ADD when finished

    public BattleInfo playerInfo;
    public BattleInfo enemyInfo;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    //sets up battle 
    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(PlayerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Units>();
        GameObject enemyGO = Instantiate(EnemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Units>();

        //dialogueText.text = enemyUnit.unitsName;
        //unit name in text box

        playerInfo.setHUD(playerUnit);
        enemyInfo.setHUD(enemyUnit);

        yield return new WaitForSeconds(3f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();

    }

    //attack system
    IEnumerator PlayerAttack()
    {
        //damage enemy
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyInfo.setHealth(enemyUnit.currHealth);
        //dialogueText.text = "Attack successful";

        yield return new WaitForSeconds(2f);

        if(isDead){
            //end battle
            state = BattleState.WON;
            EndBattle();
        }
        else {
            //enemy turn
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        //dialogueText.text = enemyUnit.unitsName + "is attacking";

        yield return new WaitForSeconds(1f); //waits a second

        bool isDead playerUnit.TakeDamage(enemyUnit.damage); //damage the player

        playerInfo.setHealth(playerUnit.currHealth); 

        yield return new WaitForSeconds(1f); //wait again

        //check if dead or not and change states
        if(isDead) {
            state = BattleState.LOST; //lost
            EndBattle();
        }
        else {
            state = BattleState.PLAYERTURN; //player turn
            PlayerTurn();
        }
    }

    //end of battle scene
    void EndBattle() 
    {
        if(state == BattleState.WON) {
            //dialogueText.text = "You won!";
        }
        else if(state == BattleState.LOST) {
            //dialogueText.text = "You were defeated.";
        }
    }

    //player chooses an action
    void PlayerTurn()
    {
        //dialogueText.text = "Choose an action";
    }

    //heals player
    IEnumerator PlayerHeal() 
    {
        playerUnit.Heal(10); //heals 10 health

        playerInfo.setHealth(playerUnit.currHealth);
        //dialogueText.text = "Healed!";

        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }

    //attack button
    public void OnAttackButton()
    {
        //checks if its players turn
        if(state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }

    //heal button
    public void OnHealButton()
    {
        //checks if its players turn
        if(state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerHeal());
    }

}