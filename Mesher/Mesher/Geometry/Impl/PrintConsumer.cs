using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry.Impl {
	class PrintConsumer : MeshConsumer {

		public void Accept(Mesh mesh, bool total) {
			if(!total)
				Console.WriteLine("Accepted mesh: " + mesh);
			else
				Console.WriteLine("Total: " + mesh);
		}
	}
}