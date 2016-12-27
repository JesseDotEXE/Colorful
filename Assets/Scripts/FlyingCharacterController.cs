using UnityEngine;
using System.Collections;

public class FlyingCharacterController : MonoBehaviour 
{
    public float ambiantSpeed = 100.0f;
    public float flySpeed;
    public float rotationSpeed = 100.0f;

    private LineRenderer pointer;
    private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
    {
        pointer = GetComponent<LineRenderer>();
        rigidBody = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.forward);
        //RotateWithKeyboard();
        //MoveForward();

        //Quaternion addRotation = Quaternion.identity;
        //float roll = 0f;
        //float pitch = 0f;
        //float yaw = 0f;

        //roll = Input.GetAxis("Roll") * (Time.deltaTime * rotationSpeed);
        //pitch = Input.GetAxis("Pitch") * (Time.deltaTime * rotationSpeed);
        //yaw = Input.GetAxis("Yaw") * (Time.deltaTime * rotationSpeed);

        //addRotation.eulerAngles = new Vector3(-pitch, yaw, -roll);

        //rigidBody.rotation *= addRotation;

        //if (Input.GetKey(KeyCode.W)) 
        //{
        //    Vector3 addPosition = Vector3.forward;
        //    addPosition = rigidBody.rotation * addPosition;
        //    rigidBody.velocity = addPosition * (Time.deltaTime * ambiantSpeed);
        //}
        //else if(Input.GetKey(KeyCode.S))
        //{
        //    Vector3 addPosition = Vector3.back;
        //    addPosition = rigidBody.rotation * addPosition;
        //    rigidBody.velocity = addPosition * (Time.deltaTime * ambiantSpeed);
        //}
        //else 
        //{
        //    rigidBody.velocity = Vector3.zero;
        //}

        UpdatePointer();
    }

    private void RotateWithKeyboard() 
    {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            gameObject.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
        }

        UpdatePointer();
    }

    private void UpdatePointer() 
    {
        pointer.SetVertexCount(2);
        pointer.SetPosition(0, transform.position);
        pointer.SetPosition(1, transform.forward * 20 + transform.position);
    }
}
