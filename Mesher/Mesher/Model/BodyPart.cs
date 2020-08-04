using Mesher.Geometry;
using System;
using System.Collections.Generic;

namespace Mesher.Model {

	// body part + parameters
	class BodyPart {

		readonly BodyPartType type;
		public readonly Dictionary<String, object> args;

		public BodyPart(BodyPartType type, Dictionary<String, object> args) {
			this.type = type;
			this.args = args;
		}

		public Mesh GenerateAndModify(List<Mesh> previous, Mesh total) => type.GenerateAndModify(this, previous, total);
	}
}
