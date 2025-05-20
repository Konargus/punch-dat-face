using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class FacePunching : MonoBehaviour
{
    [SerializeField] private GameObject head;
    [SerializeField] private float punchForce = 100f;
    [SerializeField] private DecalProjector[] faceLeftDecals;
    [SerializeField] private DecalProjector[] faceRightDecals;
    [SerializeField] private DecalProjector[] faceDownDecals;
    [SerializeField] private DecalProjector[] faceFrontDecals;
    [SerializeField] private Transform[] faceLeftTransforms;
    [SerializeField] private Transform[] faceRightTransforms;
    [SerializeField] private Transform[] faceDownTransforms;
    [SerializeField] private Transform[] faceFrontTransforms;

    private PlayerInputActions inputActions;
    private Rigidbody _rb;
    private Vector3 _initialHeadPosition;
    private Quaternion _initialHeadRotation;

    private float maxScale = 3f;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        _rb = head.GetComponent<Rigidbody>();
        _initialHeadPosition = _rb.position;
        _initialHeadRotation = _rb.rotation;
    }

    private void Update()
    {
        if (_rb.position != _initialHeadPosition || _rb.rotation != _initialHeadRotation)
        {
            _rb.linearVelocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
            Vector3 newPosition = Vector3.Lerp(_rb.position, _initialHeadPosition, Time.deltaTime * 5f);
            Quaternion newRotation = Quaternion.Lerp(_rb.rotation, _initialHeadRotation, Time.deltaTime * 3f);
            _rb.Move(newPosition, newRotation);
        }
    }

    private void OnEnable()
    {
        // Subscribe to input events
        inputActions.Enable();
        inputActions.Player.PunchLeft.performed += OnPunchLeft;
        inputActions.Player.PunchRight.performed += OnPunchRight;
        inputActions.Player.PunchDown.performed += OnPunchDown;
        inputActions.Player.PunchFront.performed += OnPunchFront;
    }

    private void OnDisable()
    {
        // Unsubscribe from input events
        inputActions.Player.PunchLeft.performed -= OnPunchLeft;
        inputActions.Player.PunchRight.performed -= OnPunchRight;
        inputActions.Player.PunchDown.performed -= OnPunchDown;
        inputActions.Player.PunchFront.performed -= OnPunchFront;
        inputActions.Disable();
    }

    private void OnPunchLeft(InputAction.CallbackContext context)
    {
        AddForce(new Vector3(1, 0, 0));
        ChangeDecalsOpacity(faceRightDecals);
        ScaleTranforms(faceRightTransforms);
    }

    private void OnPunchRight(InputAction.CallbackContext context)
    {
        AddForce(new Vector3(-1, 0, 0));
        ChangeDecalsOpacity(faceLeftDecals);
        ScaleTranforms(faceLeftTransforms);
    }

    private void OnPunchDown(InputAction.CallbackContext context)
    {
        AddForce(new Vector3(0, -1, 0));
        ChangeDecalsOpacity(faceDownDecals);
        ScaleTranforms(faceDownTransforms);
    }

    private void OnPunchFront(InputAction.CallbackContext context)
    {
        AddForce(new Vector3(0, 0, 1));
        ChangeDecalsOpacity(faceFrontDecals);
        ScaleTranforms(faceFrontTransforms);
    }

    private void AddForce(Vector3 position)
    {
        Vector3 explosionPosition = _initialHeadPosition + position;
        _rb.AddExplosionForce(punchForce * 1.5f, explosionPosition, 5f);

        if (position.x == 0)
        {
            _rb.AddRelativeTorque(new Vector3(0, position.y * punchForce / 2, 0), ForceMode.Impulse);
        }
        else
        {
            _rb.AddRelativeTorque(new Vector3(position.x * punchForce / 2, 0, 0), ForceMode.Impulse);
        }
    }

    private void ChangeDecalsOpacity(DecalProjector[] decals)
    {
        foreach (var item in decals)
        {
            if (item.fadeFactor < 1f)
            {
                item.fadeFactor += 0.1f;
            }
        }
    }
    
    private void ScaleTranforms(Transform[] transforms)
    {
        foreach (var item in transforms)
        {
            if (item.transform.localScale.x < maxScale)
            {
                item.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            }
        }
    }
}
