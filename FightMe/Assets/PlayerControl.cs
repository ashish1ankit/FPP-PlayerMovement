using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed=5f;

    private PlayerMotor motor;

    void Start(){
        motor=GetComponent<PlayerMotor>();
    }

    void update(){
        float _xMov=Input.GetAxisRaw("Hroizontal");
        float _zMov=Input.GetAxisRaw("Verical");

        Vector3 _movHorizontal=transform.right*_xMov;
        Vector3 _movVertical=transform.forward*_zMov;

        Vector3 _velocity=(_movHorizontal+_movVertical).normalized*speed;

        motor.Move(_velocity);
    }
}
