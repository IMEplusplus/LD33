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
            col.GetComponent<Rigidbody2D>().velocity = delta.normalized * weapon.force / delta.magnitude;
            col.GetComponent<HitPoint>().GetDamage(weapon.damage);
        }

        if(col.gameObject.tag == "Button")
        {
            col.GetComponent<ButtonManager>().Activate();
        }
    }
}
