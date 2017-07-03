using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    /*
    *  speed : 卵の速度
    *  cubeMaterialYellow : cubeのmaterial
    *  cubeMaterialPurple : cubeのmaterial
    */
    public float speed;
    public Material cubeMaterialYellow;
    public Material cubeMaterialPurple;
    private GameManager gameManager;
    private UiController uiController;
    private Rigidbody rb;
    private Renderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        uiController = GameObject.Find("GameManager").GetComponent<UiController>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            gameManager.count -= 1;
            if (gameManager.count % 2 == 0)
            {
                rend.material = cubeMaterialPurple;
            }
            else
            {
                rend.material = cubeMaterialYellow;
            }
        }
        uiController.SetCountText(gameManager.count);
    }
}