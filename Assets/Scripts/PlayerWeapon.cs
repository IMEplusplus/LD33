using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour {
    Weapon weapon;

    bool toRight;

    void Awake() {
        weapon = GetComponent<Weapon>();
        weapon.OnAttack = AttackCoroutine;
    }

    IEnumerator AttackCoroutine(bool right) {
        toRight = right;
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
        weapon.isAttacking = false;
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (!weapon.isAttacking)
            return;

        Vector2 delta = col.transform.position - transform.position;
        if ((delta.x > 0) != toRight)
            return;

        if (col.gameObject.tag == "Elf") {
            col.GetComponent<Rigidbody2D>().velocity = delta.normalized * weapon.force / delta.magnitude;
            col.GetComponent<HitPoint>().GetDamage(weapon.damage);
        }

        if(col.gameObject.tag == "Button")
        {
            col.GetComponent<ButtonManager>().Activate();
        }
    }
}
