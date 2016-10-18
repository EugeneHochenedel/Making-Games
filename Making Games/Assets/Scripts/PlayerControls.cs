using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{

    public float movementSpeed;
    public float cameraSensitivity;

    //private float maxX = 360.0f;
    //private float minX = -360.0f;
    //private float maxY = 90.0f;
    //private float minY = -60.0f;

    //public float projectileRate;
    //public float cooldown;
    //public GameObject projectile;
    //private int projectileCount;

    //ProjectileBehavior Shot;

//    void FireProjectile()
//    {
// //       if (projectileCount < 3)
// //       {
//        GameObject playerProjectile = (GameObject)Instantiate(projectile, Camera.main.transform.position + Camera.main.transform.forward, transform.rotation);
//        playerProjectile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward, ForceMode.Force);
//        Destroy(playerProjectile, 4.0f);
////        }
//    }

	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float cameraVert = -Input.GetAxis("Mouse Y") * cameraSensitivity;
        Camera.main.transform.localRotation = Quaternion.Euler(0, 0, cameraVert);

        float cameraHorizontal = Input.GetAxis("Mouse X") * cameraSensitivity;
        //transform.Rotate(0, cameraHorizontal, 0);
        transform.Rotate(cameraVert, cameraHorizontal, 0);

        float forwardMove = Input.GetAxis("Vertical") * movementSpeed;
        float rightMove = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(rightMove, 0, forwardMove) / 2;
        speed = transform.localRotation * speed;

        CharacterController playerMotion = GetComponent<CharacterController>();
        playerMotion.Move(speed);

	    //if(Input.GetButton("Fire1") && Time.deltaTime > 5.0f)
     //   {
     //       projectileCount -= 1;
     //       FireProjectile();
     //   }
	}
}
