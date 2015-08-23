using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class Weapon : MonoBehaviour {
    public delegate IEnumerator OnAttackDelegate(bool right);
    public OnAttackDelegate OnAttack;
    
    public int damage = 1;
    public float force = 3f;

    public bool isAttacking = false;

    void Start() {
        gameObject.SetActive(false);
    }

    public void Attack(bool right) {
        if (isAttacking)
            return;

        isAttacking = true;
        gameObject.SetActive(true);
        if (OnAttack != null)
            StartCoroutine(OnAttack(right));
    }
}
