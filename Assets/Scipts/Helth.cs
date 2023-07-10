using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Helth : MonoBehaviour
{
    [SerializeField] private float _deltaHelth = 0.1f;

    private float _maxHelth = 1f;
    private float _minHelth = 0f;

    public float ActualHelth { get; private set; } = 1;

    private event UnityAction EventChangeHelth;

    public void IncreaseHelth()
    {
        if (ActualHelth >= _maxHelth)
            return;
        ActualHelth += _deltaHelth;

        EventChangeHelth.Invoke();
    }

    public void DecreaseHelth()
    {
        if (ActualHelth <= _minHelth)
            return;
        ActualHelth -= _deltaHelth;

        EventChangeHelth.Invoke();
    }

    public void AddMetodInEvent(UnityAction metod)
    {
        EventChangeHelth += metod;
    }

    public void RemoveMetodInEvent(UnityAction metod)
    {
        EventChangeHelth -= metod;
    }
}
