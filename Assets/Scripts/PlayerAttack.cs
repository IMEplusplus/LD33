using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    PlayerMovement player;
    public Weapon weapon;

    public KeyCode keyAttack = KeyCode.K;
	
    void Awake() {
        player = GetComponent<PlayerMovement>();
    }
    
	void Update () {
        if (Input.GetButton("Action") && !weapon.isAttacking) {
            weapon.Attack();
            GetComponent<Animator>().SetTrigger("Attack");
        }
	}
}
