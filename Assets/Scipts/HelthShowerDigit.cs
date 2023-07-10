using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class HelthShowerDigit : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectWithComponentHelth;
    [SerializeField] private GameObject _gameObjectWithComponentText;

    private Helth _helth;
    private TMP_Text _text;

    private void Start()
    {
        _helth = _gameObjectWithComponentHelth.GetComponent<Helth>();
        _text = _gameObjectWithComponentText.GetComponent<TMP_Text>();
    }

    private void Update()
    {

        _text.text = _helth.ActualHelth.ToString();

    }
}
