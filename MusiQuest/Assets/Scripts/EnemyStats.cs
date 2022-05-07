using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int currentEnemyHP;
    public int maxEnemyHP;
    public HealthBar healthBar;
    public GameManager gameManager;



    void Start()
    {
        currentEnemyHP = maxEnemyHP;
        healthBar.SetMaxHealth(maxEnemyHP);
    }

   
    void Update()
    {
        if(currentEnemyHP <= 0)
        {
            Destroy(gameObject);
            Dialogue.TransitionNumber = 0;
            gameManager.ResetGame();
        }

        if(currentEnemyHP > maxEnemyHP)
        {
            currentEnemyHP = maxEnemyHP;
        }
        
    }

    public void TakeDamage(int damage)
    {
        currentEnemyHP -= damage;

        healthBar.SetHealth(currentEnemyHP);
    }
}
