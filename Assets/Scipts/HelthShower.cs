using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HelthShower : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectSlider;
    [SerializeField] private float _velocity = 0.05f;

    private Slider _slider;
    private Helth _helth;
    private bool IsCorutineWork = false;

    private void Start()
    {
        _slider = _gameObjectSlider.GetComponent<Slider>();
        _helth = GetComponent<Helth>();
        _slider.value = _helth.ActualHelth;
    }

    private void Update()
    {
        if (_helth.IsHelthChange & (IsCorutineWork == false))
            StartCoroutine(CorutineChangeSliderIsActiv());
    }

    private IEnumerator CorutineChangeSliderIsActiv()
    {
        IsCorutineWork = true;

        while (_slider.value != _helth.ActualHelth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _helth.ActualHelth, _velocity * Time.deltaTime);
            yield return null;
        }

        _helth.IsHelthChange = false;
        IsCorutineWork = false;
    }
}
