using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helth : MonoBehaviour
{
    [SerializeField] private float _deltaHelth = 0.1f;
    public float ActualHelth { get; private set; } = 1;
    public bool IsHelthChange = false;

    public void IncreaseHelth()
    {
        if (ActualHelth >= 1)
            return;
        ActualHelth += _deltaHelth;
        IsHelthChange = true;
    }

    public void DecreaseHelth()
    {
        if (ActualHelth <= 0)
            return;
        ActualHelth -= _deltaHelth;
        IsHelthChange = true;
    }
}
