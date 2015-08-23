using UnityEngine;
using System.Collections;

public class ElfWeapon : MonoBehaviour {
    Weapon weapon;
    bool toRight;
    void Awake() {
        weapon = GetComponent<Weapon>();
        weapon.OnAttack = AttackCoroutine;
    }

    IEnumerator AttackCoroutine(bool right) {
        toRight = right;
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
        weapon.isAttacking = false; 
    }
}
