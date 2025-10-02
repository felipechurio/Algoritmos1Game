using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{


    private ILifeSubstract _lifeSubstract;        // Modelo
    private ILifeSubstractSound _lifeSubstractSound; // Vista
    private IhitColor _hitColor;                    // Vista

    // Asignación de las referencias (inyección por código)
    [SerializeField] private Model _model;        // MonoBehaviour concreto que implementa ILifeSubstract
    [SerializeField] private View _view;          // MonoBehaviour que implementa ILifeSubstractSound e IhitColor


    // Start is called before the first frame update
    void Start()
    {
        _lifeSubstract = _model;
        _lifeSubstractSound = _view;
        _hitColor = _view;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _lifeSubstract.SubtractLife();
            _hitColor.ChangeColorDamage();
            _lifeSubstractSound.LifeDamageSound();
        
        
        }


    }
}
