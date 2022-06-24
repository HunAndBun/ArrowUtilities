using UnityEngine;

namespace ArrowUtilities.Serialization
{
    /// <summary>
    /// <para>Static class containing serializable versions of the UnityEngine 'Vector' family of structs.</para>
    /// </summary>
    public static class SerializableVectorHelpers
    {
        /// <summary>
        /// <para>Method for easily prepping Vector2 structs for JSON serialization.
        /// <br/><b>Note: The same can be done in reverse with ".ToVector2()"</b></para>
        /// </summary>
        /// <param name="vector2">Vector to serialize</param>
        /// <returns>The same vector in a form that is more easily converted by serialization methods.</returns>
        public static Vector2Serializable ToSerializable(this Vector2 vector2)
        {
            return new Vector2Serializable(vector2);
        }
        /// <summary>
        /// <para>Method for easily prepping Vector2Int structs for JSON serialization.
        /// <br/><b>Note: The same can be done in reverse with ".ToVector2Int()"</b></para>
        /// </summary>
        /// <param name="vector2Int">Vector to serialize</param>
        /// <returns>The same vector in a form that is more easily converted by serialization methods.</returns>
        public static Vector2IntSerializable ToSerializable(this Vector2Int vector2Int)
        {
            return new Vector2IntSerializable(vector2Int);
        }
        /// <summary>
        /// <para>Method for easily prepping Vector3 structs for JSON serialization.
        /// <br/><b>Note: The same can be done in reverse with ".ToVector3()"</b></para>
        /// </summary>
        /// <param name="vector3">Vector to serialize</param>
        /// <returns>The same vector in a form that is more easily converted by serialization methods.</returns>
        public static Vector3Serializable ToSerializable(this Vector3 vector3)
        {
            return new Vector3Serializable(vector3);
        }
        /// <summary>
        /// <para>Method for easily prepping Vector3Int structs for JSON serialization.
        /// <br/><b>Note: The same can be done in reverse with ".ToVector3Int()"</b></para>
        /// </summary>
        /// <param name="vector3Int">Vector to serialize</param>
        /// <returns>The same vector in a form that is more easily converted by serialization methods.</returns>
        public static Vector3IntSerializable ToSerializable(this Vector3Int vector3Int)
        {
            return new Vector3IntSerializable(vector3Int);
        }
        /// <summary>
        /// <para>Method for easily prepping Vector3Int structs for JSON serialization.
        /// <br/><b>Note: The same can be done in reverse with ".ToVector3Int()"</b></para>
        /// </summary>
        /// <param name="vector4">Vector to serialize</param>
        /// <returns>The same vector in a form that is more easily converted by serialization methods.</returns>
        public static Vector4Serializable ToSerializable(this Vector4 vector4)
        {
            return new Vector4Serializable(vector4);
        }
    }
}