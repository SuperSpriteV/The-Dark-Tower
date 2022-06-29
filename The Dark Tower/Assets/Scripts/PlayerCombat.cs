using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    bool combo;
    int Combostep;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Attack();
        }
    }
    public void Attack()
    {
        if (Combostep == 0)
        {
            animator.Play("Attack1");
            Combostep = 1;
            return;
        }
        if (Combostep != 0)
        {
            if (combo)
            {
                combo = false;
                Combostep += 1;
            }

        }
    }
    
    public void ComboPossible()
    {
        combo = true;

    }
    public void Combo()
    {
        if (Combostep == 2)
            animator.Play("Attack2");
        if (Combostep == 3)
            animator.Play("Attack3");
    }
    

    public void ComboReset()
    {
        if (Input.GetKeyDown(KeyCode.Z)==true) 
        {
            combo = true;
           Combostep = 2;
        }
        else { 
            combo = false;
            Combostep = 0;
        }
        
    }
}    

