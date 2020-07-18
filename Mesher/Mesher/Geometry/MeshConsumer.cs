using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry {

	interface MeshConsumer {

		// Is given every generated mesh + the total model
		void Accept(Mesh mesh, bool total);
	}
}
