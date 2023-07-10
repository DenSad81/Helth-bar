using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(Helth))]
public class HelthShowerSlider : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectSlider;
    [SerializeField] private float _velocity = 0.05f;

    private Slider _slider;
    private Helth _helth;
    private bool IsCorutineWork = false;

    private void OnEnable()
    {
        _helth = GetComponent<Helth>();
        _helth.AddMetodInEvent(StartCorutineChangeSlider);
    }

    private void OnDisable()
    {
        _helth.RemoveMetodInEvent(StartCorutineChangeSlider);
    }

    private void Start()
    {
        _slider = _gameObjectSlider.GetComponent<Slider>();
        _slider.value = _helth.ActualHelth;
    }

    private void StartCorutineChangeSlider()
    {
        if (IsCorutineWork == false)
            StartCoroutine(CorutineChangeSlider());
    }

    private IEnumerator CorutineChangeSlider()
    {
        IsCorutineWork = true;

        while (_slider.value != _helth.ActualHelth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _helth.ActualHelth, _velocity * Time.deltaTime);
            yield return null;
        }

        IsCorutineWork = false;
    }
}
