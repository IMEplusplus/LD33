using UnityEngine;
using System.Collections;

public class ElfWeapon : MonoBehaviour {
    Weapon weapon;

    void Awake() {
        weapon = GetComponent<Weapon>();
        weapon.OnAttack = AttackCoroutine;
    }

    IEnumerator AttackCoroutine() {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
        weapon.isAttacking = false; 
    }
}
