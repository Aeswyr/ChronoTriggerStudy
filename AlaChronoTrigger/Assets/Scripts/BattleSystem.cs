using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState {
    START, PLAYERTURN, ENEMYTURN, WON, LOST
}

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleState state;

    Unit playerUnit; 
    Unit enemyUnit;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupBattle() {

        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerGO.GetComponent<Unit>();
        GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
        enemyGO.GetComponent<Unit>();
    }
}
