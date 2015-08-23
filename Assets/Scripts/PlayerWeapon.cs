using UnityEngine;

public class PlayerWeapon : MonoBehaviour {
    Weapon weapon;

    void Awake() {
        weapon = GetComponent<Weapon>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (!weapon.isAttacking)
            return;

        Vector2 delta = col.transform.position - transform.position;

        if (col.gameObject.tag == "Elf") {
            col.GetComponent<Rigidbody2D>().velocity = delta.normalized * Mathf.Clamp(weapon.force / delta.magnitude, 20, 20);
            col.GetComponent<HitPoint>().GetDamage(weapon.damage);
        }

        if(col.gameObject.tag == "Button")
        {
            col.GetComponent<ButtonManager>().Activate();
        }
    }
}
