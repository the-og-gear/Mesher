using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry
{

	class Face
	{

		// counterclockwise
		public List<Vec3f> Vertices { get; private set; }

		public Face(List<Vec3f> vertices)
		{
			Vertices = vertices;
		}

		public override string ToString()
		{
			return "Face{" + Vertices + "}";
		}
	}
}