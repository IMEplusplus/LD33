using UnityEngine;
using System.Collections;

public class FimDeJogo : MonoBehaviour {

    public GameObject painel;
    public GameManager gameManager;
    public GameObject gameController;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindWithTag("GameController");
        gameManager = gameController.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player" && gameManager.NoElves())
        {
            painel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
