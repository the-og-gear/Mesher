using Mesher.Geometry;
using System;
using System.Collections.Generic;

namespace Mesher.Model.Impl {

	class BoneBodyPartType : BodyPartType {

		Mesh BodyPartType.GenerateAndModify(List<KeyValuePair<string, ReadableType<object>>> args, List<Mesh> previous, Mesh total) {
			throw new NotImplementedException();
		}

		List<KeyValuePair<string, ReadableType<object>>> BodyPartType.Parameters() {
			throw new NotImplementedException();
		}
	}
}
