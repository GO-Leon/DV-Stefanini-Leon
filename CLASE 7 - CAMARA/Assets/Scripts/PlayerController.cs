using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePlayer = 3;
    public string namePlayer = "Mr. Blue";
    public float speedPlayer = 4.0f;
    public GameObject swordPlayer;
    public Vector3 initPosition = new Vector3(4, 0, 1);
    [SerializeField] private float rotationPlayer = 5.0f;
    float cameraAxis;
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
      RotatePlayer();
    }

    private void Move()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(-ejeVertical, 0, ejeHorizontal));
    }
    private void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angle = Quaternion.Euler(0, cameraAxis, 0);
        transform.localRotation = angle;
    }
}
