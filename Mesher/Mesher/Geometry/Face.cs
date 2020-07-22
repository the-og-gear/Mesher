using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry {

	class Face {

		// counterclockwise
		List<Vec3f> Vertices;

		public Face(List<Vec3f> vertices) {
			Vertices = vertices;
		}

		public override string ToString() {
			return "Face{" + Vertices + "}";
		}
	}
}