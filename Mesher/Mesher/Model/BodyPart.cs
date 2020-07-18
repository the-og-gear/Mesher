using Mesher.Geometry;
using System;
using System.Collections.Generic;

namespace Mesher.Model {

	// body part + parameters
	class BodyPart {

		readonly BodyPartType type;
		readonly List<KeyValuePair<string, ReadableType<object>>> args;

		public BodyPart(BodyPartType type, List<KeyValuePair<String, ReadableType<object>>> args) {
			this.type = type;
			this.args = args;
		}

		public Mesh GenerateAndModify(List<Mesh> previous, Mesh total) => type.GenerateAndModify(args, previous, total);
	}
}
