using HBFramework;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private Renderer _renderer;
    [SerializeField]
    private MaterialPropertyBlock _propertyBlock;
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propertyBlock = new MaterialPropertyBlock();
    }
    private void Update()
    {

        //new ChangeColorCommand(this.gameObject).Execute();
        _renderer.GetPropertyBlock(_propertyBlock);
        _propertyBlock.SetColor("_Color", GetRandomColor());
        _renderer.SetPropertyBlock(_propertyBlock);
    }



    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0.0f, 1.0f),
                            UnityEngine.Random.Range(0.0f, 1.0f),
                            UnityEngine.Random.Range(0.0f, 1.0f));
    }
}

internal class ChangeColorCommand : Command
{
    private GameObject go;

    public ChangeColorCommand(GameObject go)
    {
        this.go = go;
    }

    public override bool IsFinished => throw new NotImplementedException();

    public override void Execute()
    {
        go.GetComponent<Renderer>().material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.Range(0, 1f),
                            UnityEngine.Random.Range(0, 1f),
                            UnityEngine.Random.Range(0, 1f));
    }
}
