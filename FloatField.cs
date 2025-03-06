using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collections.Fields
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Fields/Float Field")]
    [PreserveScriptableObject]
    public class FloatField : GenericField<float> { }


    [System.Serializable]
    public class FloatReference : GenericReference<float, FloatField, FloatMB> { }

}