using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    Collider2D swordCollider;

    //public enum AttackDirection
    //{
    //    left, right
    //}

    //public AttackDirection attackDirection;

    Vector2 rightAttackOffset;

    public float damage = 1;

    private void Start()
    {
        swordCollider = GetComponent<Collider2D>();
    }

    public void swing()
    {

    }

    //public void Attack()
    //{
    //    switch (attackDirection){
    //        case AttackDirection.left:
    //           attackLeft();
    //            break;
    //        case AttackDirection.right:
    //            attackRight();
    //            break;
    //    }
        
    //}

    public void attackRight()
    {
        print("atkright");
        swordCollider.enabled = true;
        //transform.position = rightAttackOffset;
    }

    public void attackLeft()
    {
        print("atkleft");
        swordCollider.enabled = true;
        //transform.position = new Vector3(rightAttackOffset.x * 1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        swordCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemy.Health -= damage;
                enemy.Hit();
            }
        }

        if(other.tag == "BreakableObject") {
            BreakableBoulder boulder = other.GetComponent<BreakableBoulder>();
            if(boulder != null) {
                boulder.destroy();
            }
        }
    }

    public void addDamage(int amount) {
        damage = damage + amount;
        print(damage);
    }

}
