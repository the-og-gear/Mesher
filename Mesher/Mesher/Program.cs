using Mesher.Geometry;
using Mesher.Geometry.Impl;
using Mesher.Model;
using Mesher.Model.Impl;
using System.Collections.Generic;

namespace Mesher {

	class Program{
		
		static List<MeshConsumer> consumers = new List<MeshConsumer>();

		static void Main(string[] args){
			consumers.Add(new PrintConsumer());

			// create some hardcoded bones
			List<BodyPart> parts = new List<BodyPart> {
				new BodyPart(new BoneBodyPartType(), new List<KeyValuePair<string, ReadableType<object>>>()),
				new BodyPart(new BoneBodyPartType(), new List<KeyValuePair<string, ReadableType<object>>>()),
				new BodyPart(new BoneBodyPartType(), new List<KeyValuePair<string, ReadableType<object>>>())
			};
			// generate them
			List<Mesh> previous = new List<Mesh>();
			Mesh total = new Mesh();
			foreach(var item in parts) {
				Mesh generated = item.GenerateAndModify(previous, total);
				previous.Add(generated);
				total.Add(generated);
			}
			// send them to MeshConsumers
			foreach(var consumer in consumers) {
				foreach(var item in previous)
					consumer.Accept(item, false);
				consumer.Accept(total, true);
			}
		}
	}
}
