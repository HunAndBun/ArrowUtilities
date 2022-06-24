using UnityEngine;
using UnityEditor;

namespace ArrowUtilities.Editor
{
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