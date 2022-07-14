using System;
using UnityEngine;
// ReSharper disable InconsistentNaming

namespace ArrowUtilities.Serialization {
    /// <summary>
    ///     <para>Simpler Vector2 class for serialization to JSON</para>
    ///		<para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#structs">See entry on ArrowUtilities Wiki</a></para>
    /// </summary>
    [Serializable]
	public struct Vector2Serializable {
        /// <summary>
        ///     X component of the vector.
        /// </summary>
        public float x { get; set; } 
        //!!!!PLEASE NOTE: These properties don't follow the naming convention of the project on purpose!
        //They are meant to match the Unity Vector structs perfectly!
        
        /// <summary>
        ///     Y component of the vector.
        /// </summary>
        public float y { get; set; }

        /// <summary>
        ///     <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2
        /// <br/><para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#usage">See entry on ArrowUtilities Wiki</a></para></returns>
        public Vector2 ToVector2() {
			return new Vector2(x, y);
		}

		#region Constructors

        /// <summary>
        ///     Constructs a serializable vector with given x,y components.
        /// </summary>
        public Vector2Serializable(float x, float y) : this() {
			this.x = x;
			this.y = y;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector2.
        /// </summary>
        public Vector2Serializable(Vector2 vector2) : this() {
			x = vector2.x;
			y = vector2.y;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector3. 'z' value is discarded.
        /// </summary>
        public Vector2Serializable(Vector3 vector3) : this() {
			x = vector3.x;
			y = vector3.y;
		}

		#endregion
	}

    /// <summary>
    ///     <para>Simpler Vector2Int class for serialization to JSON</para>
    ///		<para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#structs">See entry on ArrowUtilities Wiki</a></para>
    /// </summary>
    [Serializable]
	public struct Vector2IntSerializable {
        /// <summary>
        ///     X component of the vector.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        ///     Y component of the vector.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        ///     <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2Int
        /// <br/><para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#usage">See entry on ArrowUtilities Wiki</a></para></returns>
        public Vector2Int ToVector2Int() {
			return new Vector2Int(x, y);
		}

		#region Constructors

        /// <summary>
        ///     Constructs a serializable vector with given x,y components.
        /// </summary>
        public Vector2IntSerializable(int x, int y) : this() {
			this.x = x;
			this.y = y;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector2Int.
        /// </summary>
        public Vector2IntSerializable(Vector2Int vector2Int) : this() {
			x = vector2Int.x;
			y = vector2Int.y;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector3Int. 'z' value is discarded.
        /// </summary>
        public Vector2IntSerializable(Vector3Int vector3Int) : this() {
			x = vector3Int.x;
			y = vector3Int.y;
		}

		#endregion
	}

    /// <summary>
    ///     <para>Simpler Vector3 class for serialization to JSON</para>
    ///		<para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#structs">See entry on ArrowUtilities Wiki</a></para>
    /// </summary>
    [Serializable]
	public struct Vector3Serializable {
        /// <summary>
        ///     X component of the vector.
        /// </summary>
        public float x { get; set; }

        /// <summary>
        ///     Y component of the vector.
        /// </summary>
        public float y { get; set; }

        /// <summary>
        ///     Z component of the vector.
        /// </summary>
        public float z { get; set; }

        /// <summary>
        ///     <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3
        /// <br/><para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#usage">See entry on ArrowUtilities Wiki</a></para></returns>
        public Vector3 ToVector3() {
			return new Vector3(x, y, z);
		}

		#region Constructors

        /// <summary>
        ///     Constructs a serializable vector with given x,y,z components.
        /// </summary>
        public Vector3Serializable(float x, float y, float z) : this() {
			this.x = x;
			this.y = y;
			this.z = z;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector3.
        /// </summary>
        public Vector3Serializable(Vector3 vector3) : this() {
			x = vector3.x;
			y = vector3.y;
			z = vector3.z;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector2 and sets z to zero.
        /// </summary>
        public Vector3Serializable(Vector2 vector2) : this() {
			x = vector2.x;
			y = vector2.y;
			z = 0;
		}

		#endregion
	}

    /// <summary>
    ///     <para>Simpler Vector3Int class for serialization to JSON</para>
    ///		<para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#structs">See entry on ArrowUtilities Wiki</a></para>
    /// </summary>
    [Serializable]
	public struct Vector3IntSerializable {
        /// <summary>
        ///     X component of the vector.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        ///     Y component of the vector.
        /// </summary>
        public int y { get; set; }

        /// <summary>
        ///     Z component of the vector.
        /// </summary>
        public int z { get; set; }

        /// <summary>
        ///     <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3Int
        /// <br/><para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#usage">See entry on ArrowUtilities Wiki</a></para></returns>
        public Vector3Int ToVector3Int() {
			return new Vector3Int(x, y, z);
		}

		#region Constructors

        /// <summary>
        ///     Constructs a serializable vector with given x,y,z components.
        /// </summary>
        public Vector3IntSerializable(int x, int y, int z) : this() {
			this.x = x;
			this.y = y;
			this.z = z;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector3Int.
        /// </summary>
        public Vector3IntSerializable(Vector3Int vector3Int) : this() {
			x = vector3Int.x;
			y = vector3Int.y;
			z = vector3Int.z;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector2Int and sets z to zero.
        /// </summary>
        public Vector3IntSerializable(Vector2Int vector2Int) : this() {
			x = vector2Int.x;
			y = vector2Int.y;
			z = 0;
		}

		#endregion
	}

    /// <summary>
    ///     <para>Simpler Vector4 class for serialization to JSON</para>
    ///		<para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#structs">See entry on ArrowUtilities Wiki</a></para>
    /// </summary>
    [Serializable]
	public struct Vector4Serializable {
        /// <summary>
        ///     X component of the vector.
        /// </summary>
        public float x { get; set; }

        /// <summary>
        ///     Y component of the vector.
        /// </summary>
        public float y { get; set; }

        /// <summary>
        ///     Z component of the vector.
        /// </summary>
        public float z { get; set; }

        /// <summary>
        ///     W component of the vector.
        /// </summary>
        public float w { get; set; }

        /// <summary>
        ///     <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector4
        /// <br/><para><a href="https://github.com/HunAndBun/ArrowUtilities/wiki/(Struct)-SerializableVectorStructs#usage">See entry on ArrowUtilities Wiki</a></para></returns>
        public Vector4 ToVector4() {
			return new Vector4(x, y, z, w);
		}

		#region Constructors

        /// <summary>
        ///     Constructs a serializable vector with given x,y,z,w components.
        /// </summary>
        public Vector4Serializable(float x, float y, float z, float w) : this() {
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector4.
        /// </summary>
        public Vector4Serializable(Vector4 vector4) : this() {
			x = vector4.x;
			y = vector4.y;
			z = vector4.z;
			w = vector4.w;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector3 and sets w to zero.
        /// </summary>
        public Vector4Serializable(Vector3 vector3) : this() {
			x = vector3.x;
			y = vector3.y;
			z = vector3.z;
			w = 0;
		}

        /// <summary>
        ///     Constructs a serializable vector with given Vector2 and sets z and w to zero.
        /// </summary>
        public Vector4Serializable(Vector2 vector2) : this() {
			x = vector2.x;
			y = vector2.y;
			z = 0;
			w = 0;
		}

		#endregion
	}
}