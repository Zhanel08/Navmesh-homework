using UnityEngine;
using UnityEngine.AI;
public class Move : MonoBehaviour
{
    private NavMeshAgent _agent;
    private RaycastHit _hit = new RaycastHit();

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out _hit))
                _agent.destination = _hit.point;
        }
    }
}