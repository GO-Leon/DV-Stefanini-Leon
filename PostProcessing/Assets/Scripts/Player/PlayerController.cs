using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] protected PlayerData pData;
    [SerializeField] LayerMask floorLayer = default;
    [SerializeField] protected bool pOne = true;
    float cameraAxis;
    private Rigidbody rb;
    //[SerializeField] private int lifePlayer = 3;
    //[SerializeField] private string namePlayer = "Capsule";
    //[SerializeField] protected float speedPlayer = 4.0f;
    //[SerializeField]    private float jumpForce;

    // Start is called before the first frame update
    void Start()
    {

           rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pOne = !pOne;
        }
              
    }

    protected void Move()
    {
        float ejeVertical = Input.GetAxisRaw("Vertical");
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(pData.speedPlayer * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));
    }
    protected void RotatePlayer()
    {
        cameraAxis += Input.GetAxis("Mouse X");
        Quaternion angle = Quaternion.Euler(0, cameraAxis + 180, 0);
        transform.localRotation = angle;
    }
    protected void Jump()
    {
        Debug.Log(pData.playerName + "El jugador salto");
        rb.AddForce(0,1 * pData.jumpForce,0);
    }
    protected bool FloorContact()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 3.0f, floorLayer))
        { 
            return true;
        }
        else return false;
    }
    
    
}
