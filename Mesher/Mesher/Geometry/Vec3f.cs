using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry {

	class Vec3f {

		float X, Y, Z;

		public Vec3f(float x, float y, float z) {
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString() {
			return "Vec3f{X=" + X + ", Y=" + Y + ", Z=" + Z + "}";
		}
	}
}
