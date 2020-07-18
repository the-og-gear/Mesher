using Mesher.Geometry;
using Mesher.Model;
using Mesher.Model.Impl;
using System;
using System.Collections.Generic;

namespace Mesher{

    class Program{
        
        static List<MeshConsumer> consumers = new List<MeshConsumer>();

        static void Main(string[] args){
            // create some hardcoded bones
            BodyPart a = new BodyPart(new BoneBodyPartType(), new List<KeyValuePair<string, ReadableType<object>>>());
            BodyPart b = new BodyPart(new BoneBodyPartType(), new List<KeyValuePair<string, ReadableType<object>>>());
            // generate them
            List<Mesh> previous = new List<Mesh>();
            Mesh total = new Mesh();
            Mesh aMesh = a.GenerateAndModify(new List<Mesh>(), total);
            total.Add(aMesh);
            previous.Add(aMesh);
            Mesh bMesh = b.GenerateAndModify(previous, total);
            total.Add(bMesh);
			// send them to MeshConsumers
			foreach(var consumer in consumers) {
                consumer.Accept(aMesh, false);
                consumer.Accept(bMesh, false);
                consumer.Accept(total, true);
			}
        }
    }
}
