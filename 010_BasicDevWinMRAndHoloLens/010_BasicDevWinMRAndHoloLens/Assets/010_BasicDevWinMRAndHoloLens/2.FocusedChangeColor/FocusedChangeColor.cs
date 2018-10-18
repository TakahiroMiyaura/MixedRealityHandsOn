using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FocusedChangeColor : MonoBehaviour , IFocusable
{

    public Material FocusEnter;
    public Material FocusExit;

    private MeshRenderer _renderer;
    
	void Start (){
        _renderer = GetComponent<MeshRenderer>();
    }
	
    public void OnFocusEnter(){
    }

    public void OnFocusExit(){
    }
}
