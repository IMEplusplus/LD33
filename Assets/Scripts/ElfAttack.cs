using UnityEngine;

public class ElfAttack : MonoBehaviour {
    ElfMovement elf;
    public float range;
    public Weapon weapon;
    public bool isAttacking;

    void Awake() {
        elf = GetComponent<ElfMovement>();
    }

    void OnTriggerStay2D(Collider2D col) {
        if (col.gameObject.tag == "Player" && !weapon.isAttacking) {
            col.GetComponent<HitPoint>().GetDamage(weapon.damage);
            weapon.Attack();
        }
    }
}