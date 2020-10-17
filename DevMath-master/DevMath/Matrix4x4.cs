using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Matrix4x4
    {
        public float[][] m = new float[4][] { new float[4], new float[4], new float[4], new float[4] };

        public Matrix4x4(float[][] _matrix)
        {
			this.m = _matrix;
        }

        public static Matrix4x4 Identity
        {
			get
			{
				return new Matrix4x4(
					new float[4][] {
						new float[4] { 1, 0, 0, 0 },
						new float[4] { 0, 1, 0, 0 },
						new float[4] { 0, 0, 1, 0 },
						new float[4] { 0, 0, 0, 1 } }
						 );
			}

			//get { throw new NotImplementedException(); }
		}

        public float Determinant
        {
            get { throw new NotImplementedException(); }
        }

        public Matrix4x4 Inverse
        {
            get { throw new NotImplementedException(); }
        }

        public static Matrix4x4 Translate(Vector3 translation)
        {
			return new Matrix4x4(
			   new float[4][]
			   {
				  new float[4] { 1, 0, 0, translation.x },
				  new float[4] { 0, 1, 0, translation.y },
				  new float[4] { 0, 0, 1, translation.z },
				  new float[4] { 0, 0, 0, 1 }
			   });

			//throw new NotImplementedException();
		}

        public static Matrix4x4 Rotate(Vector3 rotation)
        {
			//Er zijn 2 manieren om deze te berekenen

			return RotateX(rotation.x) * (RotateY(rotation.y) * RotateZ(rotation.z));

			//throw new NotImplementedException();
		}

        public static Matrix4x4 RotateX(float rotation)
        {
			return new Matrix4x4(
			   new float[4][]
			   {
				  new float[4] { 1, 0, 0, 0 },
				  new float[4] { 0, (float)Math.Cos(rotation), (float)-Math.Sin(rotation), 0 },
				  new float[4] { 0, (float)Math.Sin(rotation), (float)Math.Cos(rotation), 0 },
				  new float[4] { 0, 0, 0, 1 }
			   });

			//throw new NotImplementedException();
		}

        public static Matrix4x4 RotateY(float rotation)
        {
			return new Matrix4x4(
				new float[4][]
				{
				  new float[4] { (float)Math.Cos(rotation), 0, (float)-Math.Sin(rotation), 0 },
				  new float[4] { 0, 1, 0, 0 },
				  new float[4] { (float)Math.Sin(rotation), 0, (float)Math.Cos(rotation), 0 },
				  new float[4] { 0, 0, 0, 1 }
				});

			//throw new NotImplementedException();
		}

        public static Matrix4x4 RotateZ(float rotation)
        {
			return new Matrix4x4(
				new float[4][]
				{
				  new float[4] { (float)Math.Cos(rotation), (float)-Math.Sin(rotation), 0, 0 },
				  new float[4] { (float)Math.Sin(rotation), (float)Math.Cos(rotation), 0, 0 },
				  new float[4] { 0, 0, 1, 0 },
				  new float[4] { 0, 0, 0, 1 }
				});

			//throw new NotImplementedException();
		}

        public static Matrix4x4 Scale(Vector3 scale)
        {
			return new Matrix4x4(
				new float[4][]
				{
				  new float[4] { scale.x, 0, 0, 0 },
				  new float[4] { 0, scale.y, 0, 0 },
				  new float[4] { 0, 0, scale.z, 0 },
				  new float[4] { 0, 0, 0, 1 }
				});
			//throw new NotImplementedException();
		}

		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
        {
			throw new NotImplementedException();
		}

        public static Vector4 operator *(Matrix4x4 lhs, Vector4 rhs)
        {
            throw new NotImplementedException();
        }
    }
}
