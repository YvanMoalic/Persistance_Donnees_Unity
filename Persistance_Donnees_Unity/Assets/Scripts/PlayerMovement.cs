using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private CharacterController _characterController;
    public Vector3 move;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _characterController.Move(_speed * Time.deltaTime * move);

        if(move != Vector3.zero)
        {
            transform.forward = move;
        }
    }
}
