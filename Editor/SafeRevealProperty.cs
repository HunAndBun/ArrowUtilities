using UnityEngine;
using UnityEditor;

namespace ArrowUtilities.Editor
{
    //TODO: Either remove this class, find a way to make it work, or mark it as an at-risk property given the errors it can throw.
    public class SafeRevealProperty : PropertyAttribute
    {
    }
    
    [CustomPropertyDrawer(typeof(SafeRevealProperty))]
    public class SafeReveal : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GUI.enabled = false;
            EditorGUI.PropertyField(position, property, label, true);
            GUI.enabled = true;
        }
    }
    
}