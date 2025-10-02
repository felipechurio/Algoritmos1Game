using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private ILifeSubstract _lifeSubstract;        
    private ILifeSubstractSound _lifeSubstractSound; 
    private IhitColor _hitColor;

    [SerializeField] private Model _model;
    [SerializeField] private View _view;

    void Start()
    {
        _lifeSubstract = _model;
        _lifeSubstractSound = _view;
        _hitColor = _view;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _lifeSubstract.SubtractLife();
            StartCoroutine(_hitColor.ChangeColorDamage());
            _lifeSubstractSound.LifeDamageSound();
        }
    }
}
