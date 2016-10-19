using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{

    public float movementSpeed;
    public float cameraSensitivity;

    public float projectileRate;
    public float cooldown;
    public GameObject projectile;
    //private int projectileCount;

    public GameObject Targeted;

    bool visible;

    //ProjectileBehavior Shot;

    void FireProjectile()
    {
        
        GameObject playerProjectile = (GameObject)Instantiate(projectile, Camera.main.transform.position + Camera.main.transform.forward, transform.rotation);
       // playerProjectile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward, ForceMode.Force);
        Destroy(playerProjectile, 4.0f);
    }

    // Use this for initialization
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray temp = new Ray(transform.position, transform.forward);
        RaycastHit Hit;

        if(Physics.Raycast(temp, out Hit, 100))
        {

        }

        Vector3 LookingAt = (Targeted.transform.position - transform.position).normalized;
        float fDotProd = Vector3.Dot(LookingAt, transform.forward);

        if(fDotProd > 0.9)
        {
            visible = true;
        }

        else
        {
            visible = false;
        }

        Debug.Log(visible);

        float cameraVert = -Input.GetAxis("Mouse Y") * cameraSensitivity;
        //Camera.main.transform.localRotation = Quaternion.Euler(0, 0, cameraVert);
        transform.Rotate(cameraVert, 0, 0);

        float cameraHorizontal = Input.GetAxis("Mouse X") * cameraSensitivity;
        transform.Rotate(0, cameraHorizontal, 0);
        //transform.Rotate(cameraVert, cameraHorizontal, 0);

        float forwardMove = Input.GetAxis("Vertical") * movementSpeed;
        float rightMove = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(rightMove, 0, forwardMove) / 2;
        speed = transform.localRotation * speed;

        CharacterController playerMotion = GetComponent<CharacterController>();
        playerMotion.Move(speed);

        cooldown += Time.deltaTime;

	    if(Input.GetButton("Fire1") && cooldown > 5.0f)
        {
            cooldown = 0;
            FireProjectile();
        }
	}
}
