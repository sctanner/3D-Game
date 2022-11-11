using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MAX_HEALTH = 100;
    public float currHealth;
    //public GameObject healthBar;

    //public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currHealth = MAX_HEALTH;
    }

    //when player takes damage
    void takeDamage(int amount)
    {
        currHealth -= amount;

        if (currHealth <= 0)
        {
            //death animation
            //anim.SetBool("isDead", true);
        }
    }

    //when player heals
    void Heal(int amount)
    {
        currHealth += amount;

        if (currHealth > MAX_HEALTH)
        {
            currHealth = MAX_HEALTH;
        }
    }
}
