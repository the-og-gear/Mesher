using Mesher.Geometry;
using System;
using System.Collections.Generic;

namespace Mesher.Model.Impl {

	class BoneBodyPartType : BodyPartType {

		Mesh BodyPartType.GenerateAndModify(BodyPart from, List<Mesh> previous, Mesh total) {
			// no parameters yet
			// let's just make a simple square
			return new Mesh(from, new List<Face>(){new Face(new List<Vec3f>(){ new Vec3f(0, 0, 0), new Vec3f(1, 0, 0), new Vec3f(1, 1, 0), new Vec3f(0, 1, 0) })});
		}

		List<KeyValuePair<string, ReadableType<object>>> BodyPartType.Parameters() {
			return new List<KeyValuePair<string, ReadableType<object>>>();
		}
	}
}