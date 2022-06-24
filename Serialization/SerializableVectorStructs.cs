using System;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace ArrowUtilities.Serialization
{
    
    /// <summary>
    /// <para>Simpler Vector2 class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector2Serializable
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public float y { get; set; }

        #region Constructors

        /// <summary>
        /// Constructs a serializable vector with given x,y components.
        /// </summary>
        public Vector2Serializable(float x, float y) : this()
            {
                this.x = x;
                this.y = y;
            }
            /// <summary>
            /// Constructs a serializable vector with given Vector2.
            /// </summary>            
            public Vector2Serializable(Vector2 vector2) : this()
            {
                this.x = vector2.x;
                this.y = vector2.y;
            }
            /// <summary>
            /// Constructs a serializable vector with given Vector3. 'z' value is discarded.
            /// </summary>           
            public Vector2Serializable(Vector3 vector3) : this()
            {
                this.x = vector3.x;
                this.y = vector3.y;
            }
        #endregion

        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2</returns>
        public Vector2 ToVector2()
        {
            return new Vector2(x, y);
        }
        
    }
    /// <summary>
    /// <para>Simpler Vector2Int class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector2IntSerializable
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public int x { get; set; }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public int y { get; set; }

        #region Constructors
        /// <summary>
        /// Constructs a serializable vector with given x,y components.
        /// </summary>
        public Vector2IntSerializable(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector2Int.
        /// </summary>            
        public Vector2IntSerializable(Vector2Int vector2Int) : this()
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector3Int. 'z' value is discarded.
        /// </summary>
        public Vector2IntSerializable(Vector3Int vector3Int) : this()
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
        }
        #endregion
        
        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector2Int</returns>
        public Vector2Int ToVector2Int()
        {
            return new Vector2Int(x, y);
        }
    }
    /// <summary>
    /// <para>Simpler Vector3 class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector3Serializable
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public float y { get; set; }
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public float z { get; set; }

        #region Constructors
            /// <summary>
            /// Constructs a serializable vector with given x,y,z components.
            /// </summary>
            public Vector3Serializable(float x, float y, float z) : this()
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            /// <summary>
            /// Constructs a serializable vector with given Vector3.
            /// </summary>
            public Vector3Serializable(Vector3 vector3) : this()
            {
                this.x = vector3.x;
                this.y = vector3.y;
                this.z = vector3.z;
            }    
            /// <summary>
            /// Constructs a serializable vector with given Vector2 and sets z to zero.
            /// </summary>
            public Vector3Serializable(Vector2 vector2) : this()
            {
                this.x = vector2.x;
                this.y = vector2.y;
                this.z = 0;
            }
            

        #endregion

        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3</returns>
        public Vector3 ToVector3()
        {
            return new Vector3(x, y, z);
        }
    }
    /// <summary>
    /// <para>Simpler Vector3Int class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector3IntSerializable
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public int x { get; set; }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public int y { get; set; }
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public int z { get; set; }

        #region Constructors
        /// <summary>
        /// Constructs a serializable vector with given x,y,z components.
        /// </summary>
        public Vector3IntSerializable(int x, int y, int z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector3Int.
        /// </summary>
        public Vector3IntSerializable(Vector3Int vector3Int) : this()
        {
            this.x = vector3Int.x;
            this.y = vector3Int.y;
            this.z = vector3Int.z;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector2Int and sets z to zero.
        /// </summary>
        public Vector3IntSerializable(Vector2Int vector2Int) : this()
        {
            this.x = vector2Int.x;
            this.y = vector2Int.y;
            this.z = 0;
        }
        #endregion
        
        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3Int</returns>
        public Vector3Int ToVector3Int()
        {
            return new Vector3Int(x, y, z);
        }
    }
    /// <summary>
    /// <para>Simpler Vector4 class for serialization to JSON</para>
    /// </summary>
    [Serializable]
    public struct Vector4Serializable
    {
        /// <summary>
        /// X component of the vector.
        /// </summary>
        public float x { get; set; }
        /// <summary>
        /// Y component of the vector.
        /// </summary>
        public float y { get; set; }
        /// <summary>
        /// Z component of the vector.
        /// </summary>
        public float z { get; set; }
        /// <summary>
        /// W component of the vector.
        /// </summary>
        public float w { get; set; }

        #region Constructors
        /// <summary>
        /// Constructs a serializable vector with given x,y,z,w components.
        /// </summary>
        public Vector4Serializable(float x, float y, float z, float w) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector4.
        /// </summary>
        public Vector4Serializable(Vector4 vector4) : this()
        {
            this.x = vector4.x;
            this.y = vector4.y;
            this.z = vector4.z;
            this.w = vector4.w;
        }
        /// <summary>
        /// Constructs a serializable vector with given Vector3 and sets w to zero.
        /// </summary>
        public Vector4Serializable(Vector3 vector3) : this()
        {
            this.x = vector3.x;
            this.y = vector3.y;
            this.z = vector3.z;
            this.w = 0;
        }    
        /// <summary>
        /// Constructs a serializable vector with given Vector2 and sets z and w to zero.
        /// </summary>
        public Vector4Serializable(Vector2 vector2) : this()
        {
            this.x = vector2.x;
            this.y = vector2.y;
            this.z = 0;
            this.w = 0;
        }
        

        #endregion

        /// <summary>
        /// <para>Method for ease of conversion post-deserialization</para>
        /// </summary>
        /// <returns>Original UnityEngine implementation of Vector3</returns>
        public Vector3 ToVector3()
        {
            return new Vector3(x, y, z);
        }
    }
    
}