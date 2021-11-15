using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPlayer : MonoBehaviour
{
    public class Player
    {
        public int attack;
        public int defense;
        public int health;
        public string playerClass;
        public string name;

        //Custom values for att, def, hp for generic character?
        public Player(int att, int def, int hp)
        {
            attack = att;
            defense = def;
            health = hp;
        }

        //Default values for att, def, hp
        //Custom values for Character name and class
        public Player(string charName, string classType)
        {
            name = charName;
            playerClass = classType;
            attack = 10;
            defense = 10;
            health = 20;

        }

        public Player()
        {
            attack = 10;
            defense = 10;
            health = 20;
        }


    }

    public Player playerStats = new Player(10, 10, 20);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerStats.health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
