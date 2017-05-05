using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamSphere : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;
    Material _material;

    private Rigidbody rb;
    public GameObject target;
    public float attractionForce;

    void Awake()
    {
        //target = GameObject.Find("Target");
    }

    // Use this for initialization
    void Start()
    {
        _material = GetComponent<MeshRenderer>().materials[0];
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_useBuffer)
        {
            //transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._bandBuffer[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
            Color _color = new Color(AudioPeer._audioBandBuffer [_band] - .1f, AudioPeer._audioBandBuffer[_band] - .3f, AudioPeer._audioBandBuffer[_band] - .3f);
            _material.SetColor("_EmissionColor", _color);
            rb.AddForce((target.transform.position - transform.position) * AudioPeer._audioBandBuffer[_band]);

            if (_band == 0)
            {
                rb.AddExplosionForce(5.0f, transform.position, 5.0f);
            }
        }

        if (!_useBuffer)
        {
            //transform.localScale = new Vector3(transform.localScale.x, (AudioPeer._freqBand[_band] * _scaleMultiplier) + _startScale, transform.localScale.z);
            Color _color = new Color(AudioPeer._audioBandBuffer[_band] - .1f, AudioPeer._audioBandBuffer[_band] - .2f, AudioPeer._audioBandBuffer[_band] - .2f);
            _material.SetColor("_EmissionColor", _color);
            rb.AddForce((target.transform.position - transform.position) * attractionForce);
        }
    }

    //void FixedUpdate()
    //{
    //    rb.AddForce((target.transform.position - transform.position) * attractionForce);
    //}
}
