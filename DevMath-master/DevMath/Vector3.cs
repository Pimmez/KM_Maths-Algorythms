using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Magnitude
        {
            get { return (float)Math.Sqrt(x * x + y * y + z * z); }
			//throw new NotImplementedException();
		}

		public Vector3 Normalized
        {
			get { return this / Magnitude; }
			//throw new NotImplementedException();
		}

		public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v)
        {
			return new Vector3(v.x, v.y, 0f);
			//throw new NotImplementedException();
		}

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
			return (lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z);
            //throw new NotImplementedException();
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
			return new Vector3(lhs.x * rhs.x, lhs.y * rhs.z, lhs.z * rhs.y);
            //throw new NotImplementedException();
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
			return (a + (b - a) * t);
            //throw new NotImplementedException();
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
			return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
            //throw new NotImplementedException();
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
			return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
            //throw new NotImplementedException();
        }

        public static Vector3 operator -(Vector3 v)
        {
			return new Vector3(-v.x, -v.y, -v.z);
			//throw new NotImplementedException();
		}

        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
			return new Vector3(lhs.x * scalar, lhs.y * scalar, lhs.z * scalar);
            //throw new NotImplementedException();
        }

        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
			return new Vector3(lhs.x / scalar, lhs.y / scalar, lhs.z / scalar);
			//throw new NotImplementedException();
        }
    }
}
