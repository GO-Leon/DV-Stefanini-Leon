using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePlayer = 3;
    public string namePlayer = "Mr. Blue";
    public float speedPlayer = 1f;
    public GameObject swordPlayer;
    public Vector3 initPosition = new Vector3(4, 2, 1);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = initPosition;
        swordPlayer.GetComponent<SwordController>().SetSwordName("Espadon 9000");
        swordPlayer.transform.position = transform.position + Vector3.forward;
        swordPlayer.transform.localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
      Move();
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(-ejeVertical, 0, ejeHorizontal));
    }
}
