using System.Collections.Generic;

namespace Mesher.Model.Impl {

	class HardcodedAnatomyProvider : AnatomyProvider {
		public List<BodyPart> Get() {
			return new List<BodyPart> {
				new BodyPart(new BoneBodyPartType(), new Dictionary<string, object>()),
				new BodyPart(new BoneBodyPartType(), new Dictionary<string, object>()),
				new BodyPart(new BoneBodyPartType(), new Dictionary<string, object>())
			};
		}
	}
}