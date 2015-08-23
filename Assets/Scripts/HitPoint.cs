using UnityEngine;

public class HitPoint : MonoBehaviour {
    int hpMax = 10;
    public int hp = 1;
    public bool alive = true;

    public delegate void OnDeathDelegate();
    public OnDeathDelegate OnDeath;

    public GameObject gameManager;

    public void GetDamage(int damage) {
        hp -= damage;
        if (hp <= 0) {
            hp = 0;
            alive = false;
            if (OnDeath != null)
                OnDeath();
        }
    }
    public void Heal(int amount) {
        hp += amount;
        if (hp >= hpMax)
            hp = hpMax;
    }
}