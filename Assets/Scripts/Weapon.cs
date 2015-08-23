using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider2D))]
public class Weapon : MonoBehaviour {
    public delegate IEnumerator OnAttackDelegate();
    public OnAttackDelegate OnAttack;

    AudioSource audio;
    
    public int damage = 1;
    public float force = 3f;

    public bool isAttacking = false;

    void Start() {
        gameObject.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    void Update() {
        if (!isAttacking) {
            gameObject.SetActive(false);
        }
    }

    public void Attack() {
        if (isAttacking)
            return;

        isAttacking = true;
        gameObject.SetActive(true);
        audio.Play();

        if (OnAttack != null)
            StartCoroutine(OnAttack());
    }
}
