using Mesher.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Model {

	interface BodyPartType {

		// gen model
		Mesh GenerateAndModify(List<KeyValuePair<String, ReadableType<object>>> args, List<Mesh> previous, Mesh total);

		// toughness/elasticity/etc at location

		// parameters
		List<KeyValuePair<String, ReadableType<object>>> Parameters();
	}
}
