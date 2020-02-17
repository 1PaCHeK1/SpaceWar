using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

    public float speed = 6.0F;
    //public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    //  <--andoroid controller
    public Vector3 moveLeftVector;
	public Vector3 moveRightVector;
    public bool isRight;
    public bool isLeft;
    // android -->
    void Update()
    {
        if(gameObject.name != "Player")
            return;

        CharacterController controller = GetComponent<CharacterController>();
        if(isLeft == true)
        {
            moveDirection = moveLeftVector * Time.deltaTime * speed;
        }
        else if(isRight == true)
        {
            moveDirection = moveRightVector * Time.deltaTime * speed;
        }
        else
        {
            /// Получаем компонент CharacterController, который прикреплен к текущему GameObject
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Debug.Log("Input.GetAxis = " + moveDirection);
            /// Преобразование кординат текущего объекта изи локальных в  world space
            moveDirection = transform.TransformDirection(moveDirection);
        }
        
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
    }

    public void TurnLeft(bool _is)
    {
        isLeft = _is;
        if(_is == true)
            gameObject.transform.Find("Ship")?.transform.Rotate(0, 0, 10);
        else
            gameObject.transform.Find("Ship")?.transform.Rotate(0, 0, -10);
    }
    public void TurnRight(bool _is)
    {
        isRight = _is;
        if(_is == true)
            gameObject.transform.Find("Ship")?.transform.Rotate(0, 0, -10);
        else
            gameObject.transform.Find("Ship")?.transform.Rotate(0, 0, 10);
    }
}
