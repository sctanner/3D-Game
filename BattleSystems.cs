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

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        GameObject playerGO = Instantiate(PlayerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Units>();
        GameObject enemyGO = Instantiate(EnemyPrefab, enemyBattleStation);
        enemyUnit = enemyGO.GetComponent<Units>();

    }

}