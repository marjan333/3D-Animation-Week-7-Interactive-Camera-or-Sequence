using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moving : MonoBehaviour
{
    NavMeshAgent _agent;
    Animator _anim;
    Vector3 _target;

    // Start is called before the first frame update
    void Start()
    {
        _agent = this.GetComponent<NavMeshAgent>();
        _anim = this.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin,out hitInfo))
            {
                _agent.SetDestination(hitInfo.point);
                _anim.SetBool("IsWalking", true);
                _target = hitInfo.point;
            }
        }
        float distance = Vector3.Distance(_target, transform.position);
        if (distance <=1.1)
            _anim.SetBool("IsWalking", false);
    }
}
