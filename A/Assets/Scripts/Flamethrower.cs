using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flamethrower : MonoBehaviour
{
    [SerializeField] float attackDuration;
    [SerializeField] private GameObject collider;
    [SerializeField] private ParticleSystem system;
    [SerializeField] private UnityEvent onStart;
    [SerializeField] private UnityEvent onStop;

    void ResetObcjects()
    {
        collider.SetActive(false);
        system.Stop();
    }

    private void Awake()
    {
        ResetObcjects();
    }

    void Update()
    {
        if(!collider.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                collider.SetActive(true);
                system.Play();
                Invoke(nameof(ResetObcjects), attackDuration);
            }
        }
    }
}
