using Mesher.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Model {

	interface BodyPartType {

		// gen model
		Mesh GenerateAndModify(BodyPart from, List<Mesh> previous, Mesh total);

		// toughness/elasticity/etc at location

		// parameters
		Dictionary<string, ReadableType<object>> Parameters();
	}
}
