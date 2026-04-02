using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 10;
    public int currenHp;
    
    public bool isDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currenHp -= damage;

        if (currenHp <= 0)
        {
            currenHp = 0;
            Die();
        }

        Debug.Log("Player Hp : " + currenHp);
    }

    void Die()
    {
        isDead = true;
        Debug.Log("Game over");
    }
}
