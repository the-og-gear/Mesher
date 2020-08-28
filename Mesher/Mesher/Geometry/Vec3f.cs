using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry
{

	class Vec3f
	{

		public float X { get; private set; }
		public float Y { get; private set; }
		public float Z { get; private set; }

		public Vec3f(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return "Vec3f{X=" + X + ", Y=" + Y + ", Z=" + Z + "}";
		}
	}
}
