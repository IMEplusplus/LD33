using UnityEngine;

public class Elf : MonoBehaviour {
    public GameObject healthPotion;
    [Range(0f,1f)]
    public float potionDrop = 0.5f;
    public GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController");
        gameManager.GetComponent<GameManager>().IncreaseElves();
    }

    void Awake() {
        GetComponent<HitPoint>().OnDeath = OnDeath;
    }

    public void Die() {
        GameObject newPotion =(GameObject) Instantiate(healthPotion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnDeath() {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;

        GetComponent<Animator>().SetBool("Dead", true);
        GetComponent<BoxCollider2D>().enabled = false;
        gameManager.GetComponent<GameManager>().DecreaseElves();
    }
}