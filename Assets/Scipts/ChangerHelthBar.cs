using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ChangerHelthBar : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _deltaHelth = 0.1f;
    [SerializeField] private float _velocity = 0.05f;

    private Slider _slideBar;
    private float _setpoint = 0f;

    private void Start()
    {
        _slideBar = _gameObject.GetComponent<Slider>();
    }

    private void Update()
    {
        _slideBar.value = Mathf.MoveTowards(_slideBar.value, _setpoint, _velocity * Time.deltaTime);
    }

    public void IncreaseHelth()
    {
        _setpoint += _deltaHelth;
    }

    public void DecreaseHelth()
    {
        _setpoint -= _deltaHelth;
    }
}
